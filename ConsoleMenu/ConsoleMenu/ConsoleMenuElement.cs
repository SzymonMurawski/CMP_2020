using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    class ConsoleMenuElement
    {
        public string Label { get; set; }
        public Action ActionToRun {get; set;}
        public ConsoleMenuElement(string label, Action actionToRun)
        {
            Label = label;
            ActionToRun = actionToRun;
        }
        public override string ToString()
        {
            return Label;
        }
    }
}
