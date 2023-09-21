using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());
        string letter;

        if (gradePercentage >= 90) {
            letter = "A"; 
        } 
        else if (gradePercentage >= 80 && gradePercentage < 90 ){
            letter = "B"; 
        }
        else if (gradePercentage >= 70 && gradePercentage < 80 ){
            letter = "C"; 
        }
        else if (gradePercentage >= 60 && gradePercentage < 70 ){
            letter = "D";
        } 
        else{
            letter = "F"; 
        }

        if ( gradePercentage%10 >=7 && letter != "A" && letter!= "F"){
            letter+= "+";
        }
        else if ( gradePercentage%10<3 && letter != "F"){
            letter+= "-";
        }

        Console.WriteLine($"Your grade is: {letter}.");
        
        if (gradePercentage>=70){
            Console.WriteLine("Congrats, You passed!!!");
        }        
        else{
            Console.WriteLine("Don't give up, Better luck next time!!!"); 
        }
        // Console.WriteLine("What is your last name? ");
        // string lastName = Console.ReadLine();
        
        // Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}