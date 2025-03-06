using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        // Console.WriteLine("Hello CSE 210");
        // Console.WriteLine("Please enter your name: ");
        // string name = Console.ReadLine();
        // Console.WriteLine($"{name}");
        // for(float i = 3000.234F; i > 200.234; i -= 100.234235F)
        // {
        //     Console.WriteLine($"{i}: Bob");
        // }

        // bool correctInput = false;
        // while(!correctInput)
        bool correctInput;
        do
        {
            Console.Write("Please input you age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 0 && age < 120)
            {
                Console.WriteLine($"Your age is: {age}");
                correctInput = true;
            }
            else
                correctInput = false;
        } while(!correctInput);


        Random newRandomNumber = new Random();
        for(int i = 0; i < 100; i++)
        {
            int number = newRandomNumber.Next(1, 1000);
            Console.WriteLine($"(i): (number)");
        }
    }
}