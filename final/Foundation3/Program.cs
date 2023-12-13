using System;

class Program
{
    static void Main(string[] args)
    {
        //Lecture instance
        Lecture lecture = new Lecture("Introduction to C#", "Mosh", "9:00am");
        //Outdoor instance
        Outdoor outdoor = new("Hiking", "Mosh", "9:00am", "TBD", "TBD","Sunny");

        //Reception instance
        Reception reception = new Reception("Networking Event", "Join us for a night of networking", DateTime.Now, "6:00pm", "Conference Room A", "Yes");

        //Display Summary
        lecture.DisplaySummary();
        outdoor.DisplaySummary();
        reception.DisplaySummary();
        
     
    }
}