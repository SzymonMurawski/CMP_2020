using System;

namespace NumberSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide a number");
            string input = Console.ReadLine();
            IEngine engine = EngineChooser(input);
            Console.WriteLine($"Number in decimal base: {engine.ConvertToDecimal()}");
            Console.WriteLine($"Number in octal base: {engine.ConvertToOctal()}");
            Console.WriteLine($"Number in hexadecimal base: {engine.ConvertToHex()}");
            Console.WriteLine($"Number in binary base: {engine.ConvertToBinary()}");
        }

        private static IEngine EngineChooser(string input)
        {
            IEngine engine;
            if (OctalEngine.IsNumberFromThisEngine(input))
            {
                engine = new OctalEngine(input);
            }
            else if (HexEngine.IsNumberFromThisEngine(input))
            {
                engine = new HexEngine(input);
            }
            else
            {
                engine = new DecimalEngine(input);
            }

            return engine;
        }
    }
}

