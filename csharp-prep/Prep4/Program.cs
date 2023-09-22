using System;

class Program
{
    static void Main(string[] args)
    {
         List<double> numbers = new List<double>();
        
        double userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = double.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        double sum = 0;
        foreach (double number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        double max = numbers[0];

        foreach (double number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
        
        double min = numbers[0];

        foreach (double number in numbers)
        {
            if (number < min && number>0)
            {
                // if this number is greater than the max, we have found the new max!
                min = number;
            }
        }

        Console.WriteLine($"The smallest positive number is: {min}");

        numbers.Sort();

        Console.WriteLine($"The sorted list is: "); 
        for (int i = 0; i < numbers.Count; i++)
        {
            double num = numbers[i];
            Console.WriteLine(num);
        }
    }
}