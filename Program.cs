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

            Console.ReadLine();
        }
    }
}
