using System;

class Program
{
    static void Main(string[] args)
    {
        //Lecture instance
        Lecture lecture = new Lecture("Introduction to C#", "Mosh", new DateTime(2023, 3, 12), "9:00am", new Address("123 Main St", "Anytown", "CA", 12345, "USA"), "John Smith", 100);
        //Outdoor instance
        Outdoor outdoor = new("Hiking", "Mosh", new DateTime(2023, 3, 11), "9:00am", new Address("123 Main St", "Anytown", "CA", 12345, "USA"),"Sunny");

        //Reception instance
        Reception reception = new Reception("Networking Event", "Join us for a night of networking", DateTime.Now, "6:00pm", new Address("123 Main St", "Anytown", "CA", 12345, "USA"), "Yes");
        
        //clear window
        Console.Clear();

        //Display Summary
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine(reception.GetFullDetails());
    }
}