using System;
using System.Collections.Generic;
using System.Text;

namespace NumberSystems
{
    public interface IEngine
    {
        string ConvertToDecimal();
        string ConvertToHex();
        string ConvertToOctal();
        string ConvertToBinary();
    }
}
