using System;

namespace JournalApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Journal journal = new Journal();
            PromptProvider promptProvider = new PromptProvider();

            while (true)
            {
                Console.WriteLine("==== Journal Program ====");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Search entries by keyword (extra feature)");
                Console.WriteLine("6. Quit");
                Console.Write("Choose an option (1-6): ");

                string choice = Console.ReadLine()?.Trim();

                if (choice == "1")
                {
                    // Write a new entry
                    string prompt = promptProvider.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry()
                    {
                        Date = DateTime.Now.ToShortDateString(),
                        Prompt = prompt,
                        Response = response
                    };

                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added!\n");
                }
                else if (choice == "2")
                {
                    // Display all entries
                    Console.WriteLine("\n=== All Journal Entries ===");
                    journal.DisplayAllEntries();
                    Console.WriteLine("=== End of Entries ===\n");
                }
                else if (choice == "3")
                {
                    // Save to a file
                    Console.Write("\nEnter filename to save to: ");
                    string filename = Console.ReadLine()?.Trim();
                    if (!string.IsNullOrEmpty(filename))
                    {
                        journal.SaveToFile(filename);
                        Console.WriteLine($"Journal saved to {filename}.\n");
                    }
                    else
                    {
                        Console.WriteLine("Invalid filename.\n");
                    }
                }
                else if (choice == "4")
                {
                    // Load from a file
                    Console.Write("\nEnter filename to load from: ");
                    string filename = Console.ReadLine()?.Trim();
                    if (!string.IsNullOrEmpty(filename))
                    {
                        journal.LoadFromFile(filename);
                        Console.WriteLine($"Journal loaded from {filename}.\n");
                    }
                    else
                    {
                        Console.WriteLine("Invalid filename.\n");
                    }
                }
                else if (choice == "5")
                {
                    // Use the extra feature: Search entries by a keyword
                    Console.Write("\nEnter a keyword to search: ");
                    string keyword = Console.ReadLine()?.Trim();
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        journal.SearchEntries(keyword);
                    }
                    else
                    {
                        Console.WriteLine("Invalid keyword.\n");
                    }
                }
                else if (choice == "6")
                {
                    // Quit
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid option. Please try again.\n");
                }
            }
        }
    }
}