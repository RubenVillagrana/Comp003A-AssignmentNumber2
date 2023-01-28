﻿/*Author: Ruben Villagrana
 * Course: Comp - 003A - L01
 * Code for assignment 2
*/
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
        }
    }
}




