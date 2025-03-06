using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job myFirstJob = new Job("Taco Time", "CEO", 2020, 2022);
        // myFirstJob.DisplayJob();
        Job mySecondJob = new Job("HP Inc", "Engineer", 2022, 2025);
        // myFirstJob.DisplayJob();
        Resume myResume = new Resume("Bob Bobba");
        myResume.AddJob(myFirstJob);
        myResume.AddJob(mySecondJob);
        myResume.DisplayResume();
    }
}