/*Author: Ruben Villagrana
 * Course: Comp - 003A - L01
 * Code for assignment 1
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
            Console.WriteLine(firstName);
            string middleName = "I don't have one";
            Console.WriteLine(middleName);
            string lastName = "Villagrana";
            Console.WriteLine(lastName);
            string inputAge = "44";
            Console.WriteLine(inputAge);
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine(yearBorn);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");


        }
    }
}




