using System;

namespace ConsoleMenu
{
    class Program
    {
        static void Main()
        {
            ConsoleMenuElement[] menuElements = {
                new ConsoleMenuElement("Option1", Option1),
                new ConsoleMenuElement("Option2", Option2),
                new ConsoleMenuElement("Option3", Option3),
                new ConsoleMenuElement("Option4", Option4),
                new ConsoleMenuElement("Add two numbers", AddNumbers),
                new ConsoleMenuElement("Exit", ExitProgram),
            };
            ConsoleMenu consoleMenu = new ConsoleMenu("Choose an option:", menuElements);
            consoleMenu.RunMenu();
        }
        public static void AddNumbers()
        {
            Console.WriteLine("x=");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("y=");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"x+y = {x+y}");
        }
        public static void Option1()
        {
            Console.WriteLine("Option1 selected");
        }
        public static void Option2()
        {
            Console.WriteLine("Option2 selected");
        }
        public static void Option3()
        {
            Console.WriteLine("Option3 selected");
        }
        public static void Option4()
        {
            Console.WriteLine("Option4 selected");
        }
        public static void ExitProgram()
        {
            Console.WriteLine("Thank you for using my program. Now we will exit.");
            Environment.Exit(0);
        }
    }
}
