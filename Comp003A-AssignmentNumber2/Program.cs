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
            Console.WriteLine("Enter an Integer For Integer1: 30");
            int y = 7;
            Console.WriteLine("Enter an Integer For Integer2: 7");
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x % y);
            
            
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Circle Area and Circumference Calculator");
            Console.WriteLine("************************************************************************");
            Console.Write("Enter Radius: ");
            double Radius = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * Radius * Radius;
            double PI = 3.14;
            double area = Math.PI * Math.Pow(Radius, 2);
            double circumference = 2 * Math.PI * Radius;
            Console.WriteLine(PI * Radius * Radius);
            Console.WriteLine("Area of circle: " + Area);
            






        }

    }
}




