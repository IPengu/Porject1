﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porject1
{
    class Program
    {
        static void Main(string[] args)//Static is a static variable and methods belong to the class instead of a specific instance
        {

            /* PENGU_TEST APP Porject 1 v.1
             * build 13 27_01_2017:20:03
             */

            int UrAge = 1; //You're one year old|A

            int boyngirl;
            boyngirl = 69; //Sets the "boyngirl" number to 69.Int is limited to non.decimal numbers

            int x = 42; // Sets "x" to 42;
            double pi = 3.14; // Sets pi to 3.14. Double is for decimal numbers
            char y = 'Z'; // Sets y to Z. char is for only one letter.
            bool isBlueSane = false; // Sets the "isBlueSane" to false,Bool is for false/true stuff
            string userNAem = "Jokubus"; // Sets "userNAem to "Jokubus". string is for like for example telling somoene's name
            string Blu = "sanita and not sane"; //Sets Blu to sanita and not sane . String is a sequence of characters

            Console.WriteLine("Hi binches!" + "Bad person name is " + userNAem); //Outputs : Hi binches!Bad person name is Jokubus
            Console.WriteLine("Bie wrold" + "x = {0}; pi = {1}", x, pi); //This gets the int x and double pi
            Console.WriteLine("Is Amefa sane? " + isBlueSane); //Outputs : Is Amefa sane? false

            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();


            //Waits for user input to continue the program
            Console.WriteLine("Press any key to continue"); 
            Console.ReadKey(); //Reads the input in order to continue
            Console.Clear();// Clears the console


            string urNaem;
            Console.WriteLine("What is your name");

            urNaem = Console.ReadLine(); // Sets the string to the user reply

            Console.WriteLine("Hello {0} ", urNaem);// Outputs Hello and the user's name

            /*Converts the user input to int32 and reads it then displays it, next is practice until i say so.*/
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So, you are {0} years old.",age);

            Console.WriteLine("What gender are you?");
            string gender = Console.ReadLine();
            Console.WriteLine("So you are a {0} .", gender);

            Console.WriteLine("Your name is {0} , you're {1} years old and your gender is {2}", urNaem, age, gender); // Collects all the inputed info and displays it.

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            /*Sets the var top to 69 and displays it.*/
            var top = 69; 
            Console.WriteLine("var top is " + top);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            /*Constants store a value that cannot be changed from their initial assignment.
             Sets const "constpi" to 3.14 and errors when trying to change it because constants can be changed.*/

            /* const double PI = 3.14;
             PI = 8;
             * The error was CS0131.
             */

            /*Sets constpi to 3.14,had to use double because a decimal numbers 
             Then prints it by using "text here" + */
            const double constpi = 3.14;
            Console.WriteLine("constpi is " + constpi);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            /*An operator is a symbol that performs mathematical or logical manipulations.
             *  You can do operations with Console.WriteLine
             *  e.g.: Console.WriteLine(x-y)
             *  The available operators are in this image :https://api.sololearn.com/DownloadFile?id=2449
             * 
             */

            int op_y = 70;
            int op_x = 1;
            int op_d = 2;
            Console.WriteLine("op_y minus op_x is {0}", op_y - op_x);
            Console.ReadKey();
            Console.WriteLine("op_y plus op_x is {0}", op_y + op_x);
            Console.ReadKey();
            Console.WriteLine("op_y multiplied by op_x is {0}", op_y + op_x);
            Console.ReadKey();
            Console.WriteLine("op_y divided by op_d is {0}", op_y / op_d);
            Console.ReadKey();

            /*You can also do this:
             * int x = 42;
             * int y = 7;
             * int z = x * y;
             * Console.WriteLine(z); 
             */

            int p = 76;
            Console.WriteLine("The int p is {0}", p);
            p = p += 5; // Equivalent to p = p + 5
            Console.WriteLine("The int p is now {0}", p);
            p = p -= 5; // Equivalent to p = p - 5
            Console.WriteLine("The int p is now {0}", p);

            int c = 8;
            Console.WriteLine("The int c is {0}", c);
            c++; // Equivalent to c = c + 1; 
            Console.WriteLine("The int c is now {0}", c); // Outputs 9

            /*The increment operator has two forms, prefix and postfix.
             * Prefix increments the value, and then proceeds with the expression. 
             * Postfix evaluates the expression and then performs the incrementing. 
             */

            int pengu = 10;
            Console.WriteLine("The int pengu is {0}", pengu);
            int pr0n = ++pengu;
            Console.WriteLine("The int pr0n is {0}", pr0n);
            int pr0ngu = pengu++;
            Console.WriteLine("The int pr0ngu is {0}", pr0ngu);
            // pengu is 10, both pr0n and pr0ngu are 11.

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            // The end.

        }
    }
}
