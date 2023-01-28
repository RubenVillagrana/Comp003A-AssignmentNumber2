/*Author: Ruben Villagrana
 * Course: Comp - 003A - L01
 * Code for assignment 2
*/
using System.Security.Cryptography.X509Certificates;

namespace ClearConsole

{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Console Section");
            Console.WriteLine("************************************************************************");

           
            
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("String Section");
            Console.WriteLine("*************************************************************************");
            string firstName = "Ruben";
            Console.WriteLine($"Enter First Name: {firstName}");
            string middleName = "jr";
            Console.WriteLine($"Enter Middle Name: {middleName}");
            string lastName = "Villagrana";
            Console.WriteLine($"Enter Last Name: {lastName}");
            string inputAge = "44";
            Console.WriteLine($"Enter Age in 2023: {inputAge}");
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

            
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Math Section");
            Console.WriteLine("************************************************************************");
            int x = 30;
            Console.WriteLine($"Enter an Integer For Integer1: {x}");
            int y = 7;
            Console.WriteLine($"Enter an Integer For Integer2: {y}");
            Console.WriteLine($"30 + 7 = 37");



        }

    }
}




