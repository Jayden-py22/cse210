using System;
using System.IO;
using System.Collections.Generic;

namespace JournalApp
{
    public class Journal
    {
        private List<Entry> _entries = new List<Entry>();

        public List<Entry> Entries
        {
            get { return _entries; }
        }

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        public void DisplayAllEntries()
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }
        }

        public void LoadFromFile(string filename)
        {
            _entries.Clear();

            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        Entry newEntry = new Entry()
                        {
                            Date = parts[0],
                            Prompt = parts[1],
                            Response = parts[2]
                        };
                        _entries.Add(newEntry);
                    }
                }
            }
        }

        public void SearchEntries(string keyword)
        {
            Console.WriteLine($"\n=== Search Results for '{keyword}' ===");

            bool foundAny = false;
            foreach (Entry entry in _entries)
            {
                if (entry.Prompt.ToLower().Contains(keyword.ToLower()) ||
                    entry.Response.ToLower().Contains(keyword.ToLower()))
                {
                    Console.WriteLine(entry.ToString());
                    foundAny = true;
                }
            }

            if (!foundAny)
            {
                Console.WriteLine("No matching entries found.");
            }

            Console.WriteLine("=== End of Search Results ===\n");
        }
    }
}