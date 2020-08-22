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

            Console.ReadLine();
        }
    }
}
