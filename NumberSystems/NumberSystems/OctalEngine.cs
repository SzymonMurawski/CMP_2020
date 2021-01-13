using System;
using System.Collections.Generic;
using System.Text;

namespace NumberSystems
{
    public class OctalEngine : IEngine
    {
        private readonly string _input;
        public OctalEngine(string input)
        {
            _input = input;
        }
        public static bool IsNumberFromThisEngine(string input)
        {
            throw new NotImplementedException();
        }

        public string ConvertToHex()
        {
            throw new NotImplementedException();
        }

        public string ConvertToBinary()
        {
            throw new NotImplementedException();
        }

        public string ConvertToOctal()
        {
            return _input;
        }

        public string ConvertToDecimal()
        {
            throw new NotImplementedException();
        }
    }
}
