using System;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("789 Oak St", "Seattle", "WA", "USA");
            Lecture lecture = new Lecture("Tech Innovations", "A lecture on the latest tech trends.", "10/15/2025", "10:00 AM", address1, "Dr. Smith", 100);

            Address address2 = new Address("321 Pine St", "Boston", "MA", "USA");
            Reception reception = new Reception("Networking Event", "An event to connect professionals.", "11/20/2025", "6:00 PM", address2, "rsvp@event.com");

            Address address3 = new Address("654 Maple St", "Denver", "CO", "USA");
            OutdoorGathering outdoor = new OutdoorGathering("Summer Festival", "An outdoor gathering with music and food.", "07/04/2025", "2:00 PM", address3, "Sunny with a chance of rain");

            Console.WriteLine("Lecture Details:");
            Console.WriteLine(lecture.GetStandardDetails());
            Console.WriteLine(lecture.GetFullDetails());
            Console.WriteLine(lecture.GetShortDescription());
            Console.WriteLine("---------------");

            Console.WriteLine("Reception Details:");
            Console.WriteLine(reception.GetStandardDetails());
            Console.WriteLine(reception.GetFullDetails());
            Console.WriteLine(reception.GetShortDescription());
            Console.WriteLine("---------------");

            Console.WriteLine("Outdoor Gathering Details:");
            Console.WriteLine(outdoor.GetStandardDetails());
            Console.WriteLine(outdoor.GetFullDetails());
            Console.WriteLine(outdoor.GetShortDescription());
            Console.WriteLine("---------------");
        }
    }
}