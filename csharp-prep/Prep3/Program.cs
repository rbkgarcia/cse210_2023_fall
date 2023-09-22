using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string play = "yes";
        while (play=="yes" || play=="y"){
            int magicNumber = randomGenerator.Next(1, 100);
            int guess = 0;
            int i=0;
            while (guess!= magicNumber){
                Console.WriteLine("What is the magic number? ");
                guess = int.Parse(Console.ReadLine());
                i++;
                if (guess>magicNumber){
                    Console.WriteLine("Lower"); 
                }
                else if (guess<magicNumber){
                    Console.WriteLine("Higher");
                }
                else{
                    Console.WriteLine($"You guessed it! at {i} attempts");
                }
            }
            Console.WriteLine("Do you want to play again? ");

            play= Console.ReadLine();
        }
    }
}