﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_try
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            // 3. Drawing a shape

            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");


            // 4. Variables


            string characterName = "John";
            int characterAge = 35;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);


            // 5. Data Types


            string phrase = "Hi!";
            char grade = 'C';
            int age = 30;
            double gpa = 3.2;
            // float gpa = 3.2;
            // decimal gpa = 3.2;
            bool isMale = true;


            // 6. Working With Strings


            Console.WriteLine("Gianluigi\nVitale");
            Console.WriteLine("Gianluigi\"Vitale");

            Console.WriteLine(characterName + " is " + characterAge);

            Console.WriteLine(characterName.Length);
            Console.WriteLine(characterName.ToUpper());
            Console.WriteLine(characterName.ToLower());
            Console.WriteLine(characterName.Contains("Jo"));
            Console.WriteLine(characterName.IndexOf("n"));
            Console.WriteLine(characterName.Substring(1));
            Console.WriteLine(characterName.Substring(1, 2));
            Console.WriteLine(characterName.Substring(characterName.IndexOf("h")));
            Console.WriteLine(characterName[2]);


            // 7. Working With Numbers


            Console.WriteLine(20);
            Console.WriteLine(21.612);
            Console.WriteLine(5 + 3);
            Console.WriteLine(5 / 2);       // always get an integer
            Console.WriteLine(5 / 2.0);     // always get an decimal
            Console.WriteLine(5 % 2);
            Console.WriteLine((4 + 2) * 3);

            int num = 6;
            num++;
            num--;
            Console.WriteLine(num);

            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(40, 30));
            Console.WriteLine(Math.Round(4.3));


            // 8. Getting user input


            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();

            Console.WriteLine("Hello " + name + " you are " + ageInput);


            // 9. Building a Calculator


            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);


            // 10. Building a Mad Lib


            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);


            // 11. Arrays


            string[] friends = new string[10];
            friends[0] = "Jim";
            friends[1] = "Kevin";

            int[] luckyNumbers = {1, 2, 3, 4, 5};
            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine(luckyNumbers[2]);


            // 12. Methods


            SayHi("Mike", 18);


            // 13. Return Statement


            Console.WriteLine(Cube(5));


            // 14. If Statements


            bool isFemale = true;
            bool isTall = true;

            if (isFemale && isTall) {
                Console.WriteLine("You are a tall female");
            } else if (isFemale && !isTall) {
                Console.WriteLine("You are a short female");
            } else {
                Console.WriteLine("You are either not female or not tall or both");
            }


            // 14. If Statements (con't)


            Console.WriteLine(GetMax(5, 4));


            // 16. Building a Better Calculator


            Console.Write("Enter a number: ");
            double numFirst = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double numSecond = Convert.ToDouble(Console.ReadLine());

            if (op == "+") {
                Console.WriteLine(numFirst + numSecond);
            } else if (op == "-") {
                Console.WriteLine(numFirst - numSecond);
            } else if (op == "*") {
                Console.WriteLine(numFirst * numSecond);
            } else if (op == "/") {
                Console.WriteLine(numFirst / numSecond);
            } else {
                Console.WriteLine("Invalid operator");
            }


            // 17. Switch Statements


            Console.WriteLine(GetDay(0));


            // 18. While Loops

            int index = 1;
            int index1 = 1;

            while (index <= 5) {
                Console.WriteLine(index);

                index++;
            }

            do {
                Console.WriteLine(index1);

                index1++;
            } while (index1 <= 5);


            // 19. Build a Guessing Game


            string secretWord = "giraffe";
            string guess = "";

            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses) {

                if (guessCount < guessLimit) {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();

                    guessCount++;
                } else {
                    outOfGuesses = true;
                }

            }

            if (outOfGuesses) {
                Console.WriteLine("You Lose!");
            } else {
                Console.WriteLine("You Win!");
            }


            // 20. For Loops


            int[] rndNumbers = {1, 2, 3, 4, 5};

            for (int i = 0; i < rndNumbers.Length; i++) {
                Console.WriteLine(rndNumbers[i]);
            }


            // 21. Building an Exponent Method


            Console.WriteLine(GetPow(4, 3));


            // 22. 2d Arrays


            int[,] myArray = new int[2,3];

            int[,] numberGrid = {
                {1, 2},
                {3, 4},
                {5, 6},
            };

            Console.WriteLine(numberGrid[0, 0]);
            Console.WriteLine(numberGrid[1, 1]);


            // 23. Comments

                /*
                    comments are made with two forward slash '//' (single line)
                    or
                    multi-line
                */



            // 24. Exception Handling


            try
            {
                Console.Write("Enter a number: ");
                int numImput = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                int numImput1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }


            // 25. Classes & Objects


            // Book book1 = new Book();                // without constructor
            // book1.title = "Harry Potter";
            // book1.author = "JK Rowling";
            // book1.pages = 400;
            //
            // Book book2 = new Book();
            // book2.title = "Lord of the Rings";
            // book2.author = "Tolkein";
            // book2.pages = 700;

            // Console.WriteLine(book1.title);
            // Console.WriteLine(book2.title);


            // 26. Constructors


            Book book3 = new Book("Harry Potter", "JK Rowling", 400);
            Book book4 = new Book("Lord of the Rings", "Tolkein", 700);

            Console.WriteLine(book3.title);
            Console.WriteLine(book4.title);


            // 27. Object Methods


            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());


            // 28. Getters & Setters


            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            Console.WriteLine(avengers.Rating);


            // 29. Static Class Attributes


            Console.WriteLine(Movie.movieCount);


            // 30. Static Methods & Classes


            UsefulTools.SayHi("Mike");


            // 31. Static Methods & Classes


            Console.WriteLine(ItalianMovie.TopMovie());

            Console.ReadLine();
        }

        static void SayHi(string name, int age)     // says hi to the user
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        static int Cube(int num)                   // cube of a number
        {
            int result = num * num * num;

            return result;
        }

        static int GetMax(int num1, int num2)   // given two int returns the max
        {
            int result;

            result = num1 > num2 ? num1 : num2;

            return result;
        }

        static string GetDay(int dayNum)        // given the number of the day of the week returns the day
        {
            string dayName;

            switch (dayNum) {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }

        static int GetPow(int baseNum, int powNum)      // returns the base num to the power of n
        {
            int result = 1;

            for (int i = 1; i <= powNum; i++) {
                result = result * baseNum;
            }

            return result;
        }
    }
}
