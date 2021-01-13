using System;
using System.Collections.Generic;
using System.Text;

namespace NumberSystems
{
    public class HexEngine : IEngine
    {
        private readonly string _input;
        public HexEngine(string input)
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
            return _input;
        }

        public string ConvertToOctal()
        {
            throw new NotImplementedException();
        }

        public string ConvertToDecimal()
        {
            throw new NotImplementedException();
        }
    }
}
