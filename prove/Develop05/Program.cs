using System;

public class Program
{
    public static void Main(string[] args)
    {
        // This program implements an Eternal Quest system for tracking goals.
        // It supports SimpleGoal, EternalGoal, and ChecklistGoal.
        // Creative features include a leveling system (level up every 1000 points)
        // and saving/loading goals data with user-provided file names.
        GoalManager manager = new GoalManager();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Goal Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals Data");
            Console.WriteLine("5. Load Goals Data");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    manager.CreateGoal();
                    break;
                case "2":
                    manager.RecordGoal();
                    break;
                case "3":
                    manager.DisplayGoals();
                    break;
                case "4":
                    Console.Write("Enter filename to save data: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveData(saveFile);
                    break;
                case "5":
                    Console.Write("Enter filename to load data: ");
                    string loadFile = Console.ReadLine();
                    manager.LoadData(loadFile);
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}