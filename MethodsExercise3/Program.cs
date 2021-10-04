using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {
        /*
         * 1 Write a method that will print to the console all numbers 1000 through -1000.
         * 2 Write a method that will print to the console numbers 3 through 999 by 3 each time.
         * 3 Write a method to accept two integers as parameters and check whether they are equal or not.
         * 4 Write a method to check whether a given number is even or odd.
         * 5 Write a method to check whether a given number is positive or negative.
         * 6 Write a method to read the age of a candidate and determine whether they can vote. 
         * Hint: use Parse()... or the safer TryParse() for an extra challenge!!
         * 
         * EX1 Write a method to check if an integer (from the user) is in the range -10 to 10.
         * EX2 Write a method to display the multiplication table(from 1 to 12) of a given integer.
         */

        //1 Write a method that will print to the console all numbers 1000 through -1000.
        static void PrintRange1000()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("-----------");
            Console.WriteLine("Method #1:");
            Console.WriteLine("-----------");

            for (int i = 1000; i >= -1000; i--)
                Console.WriteLine(i);

        }

        //2 Write a method that will print to the console numbers 3 through 999 by 3 each time.
        static void PrintByThree()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("-----------");
            Console.WriteLine("Method #2:");
            Console.WriteLine("-----------");

            for (int j = 3; j <= 999; j += 3)
                Console.WriteLine(j);

        }

        //3 Write a method to accept two integers as parameters and check whether they are equal or not.
        static void CheckIfEqual()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("-----------");
            Console.WriteLine("Method #3:");
            Console.WriteLine("-----------");
            var equals = false;
            int num1;
            int num2;

            do
            {
                Console.WriteLine("Enter 2 equal numbers:");
                num1 = Int32.Parse(Console.ReadLine());
                num2 = Int32.Parse(Console.ReadLine());

                if (num1 == num2)
                    equals = true;
                else
                    Console.WriteLine($"These 2 numbers are different, try again. \n");

            } while (!equals);

            Console.WriteLine("Both numbers are equal! You can proceed.");
        }

        //4 Write a method to check whether a given number is even or odd.
        static void CheckEvenOdd()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("-----------");
            Console.WriteLine("Method #4:");
            Console.WriteLine("-----------");
            int numCheck;

            Console.WriteLine("Type an even or an odd number:");
            numCheck = Int32.Parse(Console.ReadLine());

            var checkAnswer = (numCheck % 2 == 0) ? $"{numCheck} is an Even number." : $"{numCheck} is an Odd number.";

            Console.WriteLine(checkAnswer);
        }

        //5 Write a method to check whether a given number is positive or negative.
        static void CheckIfNegative()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("-----------");
            Console.WriteLine("Method #5:");
            Console.WriteLine("-----------");
            int numValue;

            Console.WriteLine("Type a positive or negative number:");
            numValue = Int32.Parse(Console.ReadLine());

            var checkValue = (numValue < 0) ? $"{numValue} is a Negative number." : $"{numValue} is a Positive number.";

            Console.WriteLine(checkValue);
        }

        //6 Write a method to read the age of a candidate and determine whether they can vote.
        static void CheckIfVote()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("-----------");
            Console.WriteLine("Method #6:");
            Console.WriteLine("-----------");
            int numAge;

            Console.WriteLine("Please specify your age before voting:");
            numAge = Int32.Parse(Console.ReadLine());

            var checkAge = (numAge >= 18) ? "You are allowed to vote!" : "You need to be at least 18 years of age to be allowed to vote.";

            Console.WriteLine(checkAge);
        }

        //EX1 Write a method to check if an integer (from the user) is in the range -10 to 10.
        static void CheckRange()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("-----------------");
            Console.WriteLine("Method Heat #1:");
            Console.WriteLine("-----------------");
            int numRange;

            Console.WriteLine("Please enter a number between -10 and 10");
            numRange = Int32.Parse(Console.ReadLine());

            while (numRange > 10 || numRange < -10)
            {
                Console.WriteLine($"Your number is out of the specified range! Please try again.\n");

                Console.WriteLine("Please enter a number between -10 and 10");
                numRange = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your number is within the specified range! You can proceed.");                

        }

        //EX2 Write a method to display the multiplication table(from 1 to 12) of a given integer.
        static void MultiplicationTable()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("-----------------");
            Console.WriteLine("Method Heat #2:");
            Console.WriteLine("-----------------");
            int numTable;

            Console.WriteLine("Please enter a number so we can generate its multiplication table:");
            numTable = Int32.Parse(Console.ReadLine());

            for (int m = 1; m <= 12; m++)
            {
                var multiple = numTable * m;
                Console.WriteLine($"| {numTable} x {m} = {multiple} |");
            }

        }

        static void Main(string[] args)
        {
            PrintRange1000();
            PrintByThree();
            CheckIfEqual();
            CheckEvenOdd();
            CheckIfNegative();
            CheckIfVote();
            CheckRange();
            MultiplicationTable();
        }
    }
}
