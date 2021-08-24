using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
         
        static void Main(string[] args)
        {
            
            PrintThousandDown();
            Console.ReadLine();
            Print999ByThrees();
            Console.ReadLine();
            int comparisonNumberOne = GetUserIntInput("Please enter a number.");
            int comparisonNumberTwo = GetUserIntInput($"Thank you, lets compare {comparisonNumberOne} to another number.\nWhat number would you like to compare to?");
            CheckIfEqual(comparisonNumberOne, comparisonNumberTwo);
            Console.ReadLine();    
            EvenOrOdd();
            Console.ReadLine();
            IsNumberPositive();
            Console.ReadLine();
            CanUserVote();
            Console.ReadLine();
            CheckIfInRange(-10, 10);
            Console.ReadLine();
            MultiplyNumber();
            Console.ReadLine();
        }

        public static void PrintThousandDown()
        {
            for (int index = 1000; index >= -1000; index--)
            {
                Console.WriteLine(index);
            }
        }
        public static void Print999ByThrees()
        {
            for(int index = 0; index <= 999; index++)
            {
                if(index % 3 == 0)
                {
                    Console.WriteLine(index);
                }
            }
        }
        static int GetUserIntInput(string question)
        {
            Console.WriteLine(question + "\n");
            string reply = Console.ReadLine();
            while (reply == "" || !int.TryParse(reply, out int result))
            {
                Console.WriteLine("\nPlease enter a valid response\n");
                reply = Console.ReadLine();
            }
            return int.Parse(reply);
        }
        public static void CheckIfEqual(int numOne, int numTwo)
        {
            Console.WriteLine(numOne == numTwo ? $"{numOne} is equal to {numTwo}" : $"{numOne} is not equal to {numTwo}");
        }
        public static void EvenOrOdd()
        {
            int input = GetUserIntInput("Please enter an even or odd number.");
            Console.WriteLine(input % 2 == 0 ? "You entered an even number." : "You entered an odd number.");
        }
        public static void IsNumberPositive()
        {
            int input = GetUserIntInput("Please enter a number that might be negative or positive.");
            Console.WriteLine(input < 0 ? "You entered a negative number." : "You entered a positive number.");
        }
        public static void CanUserVote()
        {
            int age = GetUserIntInput("Please enter your age.");
            Console.WriteLine( age < 18 ? "You're still too young to vote." : "You're old enough to vote.");
        }
        public static void CheckIfInRange(int minNumber, int maxNumber)
        {
            int input = GetUserIntInput("Please choose a number.");
                if (input >= minNumber && input <= maxNumber)
                { 
                Console.WriteLine($"{input} is between {minNumber} and {maxNumber}"); 
                }
            else
                Console.WriteLine($"{input} is not between {minNumber} and {maxNumber}");
        }
        public static void MultiplyNumber()
        {
            int numberToMultiply = GetUserIntInput("Please enter a number to multiply.");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{numberToMultiply} x {i} = {numberToMultiply*i}");
            }
        }
    
    }

}
