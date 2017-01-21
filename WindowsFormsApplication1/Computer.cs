using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_V5
{
    class Computer
    {
        private List<String> DeviseSection = new List<string>();
        public string ComputerName { get; private set; }
        public uint TheNumbersOfPort { get; set; }
        public uint TheNumbersOfFreePort { get; set;}
        public Computer(string _computerName,uint _port)
        {
            ComputerName = _computerName;
                TheNumbersOfPort = _port;
        }
    }
}
