using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    
    // Extra Feature: Scripture Library and Multiple Sessions
    // -------------------------------------------------------
    // This program includes a ScriptureLibrary class to store multiple scriptures.
    // At startup, a random scripture is selected for memorization.
    // The user can press Enter to hide more words or type ‘quit’ to exit the current scripture session.
    // Once all words are hidden, the program asks if the user wants to memorize another scripture, supporting multiple memorization sessions.

    public class Program
    {
        public static void Main(string[] args)
        {
            ScriptureLibrary library = new ScriptureLibrary();

            // Add scripture: John 3:16
            library.AddScripture(new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life"
            ));

            // Add scripture: Proverbs 3:5-6
            library.AddScripture(new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding in all your ways submit to him and he will make your paths straight"
            ));

            // Add scripture: Psalm 23:1-2
            library.AddScripture(new Scripture(
                new Reference("Psalm", 23, 1, 2),
                "The Lord is my shepherd I shall not want He makes me lie down in green pastures"
            ));

            bool continueProgram = true;
            while (continueProgram)
            {
                Scripture scripture = library.GetRandomScripture();
                if (scripture == null)
                {
                    Console.WriteLine("The scripture library is empty. Exiting program.");
                    break;
                }

                Console.Clear();
                Console.WriteLine("Start memorizing the scripture!");
                Console.WriteLine("Press Enter to hide more words until all words are hidden.");
                Console.WriteLine("Type 'quit' to exit the current scripture session.");

                while (true)
                {
                    Console.Clear();
                    scripture.DisplayScripture();

                    if (scripture.IsCompletelyHidden())
                    {
                        Console.WriteLine("\nAll words are hidden!");
                        break;
                    }

                    Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit the current scripture:");
                    string input = Console.ReadLine();
                    if (input.Trim().ToLower() == "quit")
                    {
                        break;
                    }
                    // Hide 3 words at a time.
                    scripture.HideRandomWords(3);
                }

                // After memorizing the current scripture, ask if the user wants to memorize another.
                Console.WriteLine("\nDo you want to memorize another scripture? (y/n):");
                string response = Console.ReadLine();
                if (response.Trim().ToLower() != "y")
                {
                    continueProgram = false;
                }
            }
        }
    }
}
