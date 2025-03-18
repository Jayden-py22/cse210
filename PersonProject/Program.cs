// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        Person myPerson = new Person("Bob", "Bobba", 97);

        Console.WriteLine($"{myPerson.DisplayPersonInfo()}");

        Policeman myPoliceman = new Policeman("Gun", "Bob", "Bobba", 97);
        Console.WriteLine($"{myPoliceman.DisplaypolicManInfo()}");
    }
}
