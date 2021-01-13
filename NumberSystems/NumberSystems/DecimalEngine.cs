using System;
using System.Collections.Generic;
using System.Text;

namespace NumberSystems
{
    public class DecimalEngine : IEngine
    {
        private readonly string _input;
        public DecimalEngine(string input)
        {
            _input = input;
        }
        public static bool IsNumberFromThisEngine(string input)
        {
            throw new NotImplementedException();
        }
        public string ConvertToBinary()
        {
            throw new NotImplementedException();
        }

        public string ConvertToHex()
        {
            throw new NotImplementedException();
        }

        public string ConvertToOctal()
        {
            throw new NotImplementedException();
        }

        public string ConvertToDecimal()
        {
            return _input;
        }
    }
}
