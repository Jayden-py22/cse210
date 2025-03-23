using System;

class Program
{
    static void BackToTheFuture()
    {
        DateTime now = DateTime.Now;
        DateTime future = now.AddSeconds(5);
        string[] spinnerStrings = { ":)", ":("};
        int counter = 0;
        
        Console.Write("Waiting for the future: ");
        while (now < future)
        {
            Thread.Sleep(100);
            Console.Write($"\rWaiting for the future: {spinnerStrings[counter % spinnerStrings.Length]} ");
            counter++;
            now = DateTime.Now;
        }
        
        Console.WriteLine("\nThe future has arrived!");
    }

    static void Main(string[] args)
    {
        BackToTheFuture();
    }
}