using System;
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

            //Waits for user input to continue the program
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(); //Reads the input in order to continue


            string urNaem;
            Console.WriteLine("What is your name");

            urNaem = Console.ReadLine(); // Sets the string to the user reply

            Console.WriteLine("Hello {0} ", urNaem);// Outputs Hello and the user's name

            /*Converts the user input to int32 and reads it then displays it, next is practice until i say so.*/
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So, you are {0} years old.", age);

            Console.WriteLine("What gender are you?");
            string gender = Console.ReadLine();
            Console.WriteLine("So you are a {0} .", gender);

            Console.WriteLine("Your name is {0} , you're {1} years old and your gender is {2}", urNaem, age, gender); // Collects all the inputed info and displays it.

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            /*Sets the var top to 69 and displays it.*/
            var top = 69;
            Console.WriteLine("var top is " + top);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

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

            /*An operator is a symbol that performs mathematical or logical manipulations.
             *  You can do operations with Console.WriteLine
             *  e.g.: Console.WriteLine(x-y)
             *  The available operators are in this image :https://api.sololearn.com/DownloadFile?id=2449
             * 
             */

            int op_y = 70;
            int op_x = 1;
            Console.WriteLine("Press any key to calculate op_y minus op_x", op_y - op_x);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();


        }
    }
}
