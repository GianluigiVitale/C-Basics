using System;
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
            } while (index1 <= 5)

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

        static int GetMax(int num1, int num2)
        {
            int result;

            result = num1 > num2 ? num1 : num2;

            return result;
        }

        static string GetDay(int dayNum)
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
    }
}
