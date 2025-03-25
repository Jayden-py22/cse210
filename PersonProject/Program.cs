// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // Person myPerson = new Person("Bob", "Bobba", 97);

        // Console.WriteLine($"{myPerson.DisplayPersonInfo()}");

        Policeman myPoliceman = new Policeman("Taser", "Joe", "Mamma", 32);
        Console.WriteLine($"{myPoliceman.DisplayPolicManInfo()}");
        Console.WriteLine($"{myPoliceman.DisplayPersonInfo()}");

        myPoliceman.SetHeight(73);
        // myPoliceman._height = 76;
        Console.WriteLine($"Police Man Height: {myPoliceman.GetHeight()} inches");
        Console.WriteLine($"{myPoliceman.GetName()}");

        myPoliceman.SetHeight(100);
        Console.WriteLine($"Police Man");

        Doctor myDoctor = new Doctor("MD", "Dr.", "Doolittle", 45);
        Console.WriteLine($"{myDoctor.DisplayDoctorInfo()}");
        Console.WriteLine($"{myDoctor.DisplayPersonInfo()}");
        Console.WriteLine($"{myDoctor.GetName()}");
        Console.WriteLine($"{myDoctor.GetHobbies()}");
    
    }
}
