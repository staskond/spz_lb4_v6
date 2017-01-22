using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_V5
{
    class Computer
    {
        private List<Device> DeviseSection = new List<Device>();
        public string ComputerName { get; private set; }
        public uint TheNumbersOfPort { get; set; }
        private uint theNumbersOfFreePort;
        public Computer(string _computerName,uint _port)
        {
            ComputerName = _computerName;
            TheNumbersOfPort = _port;
        }

        public void AddDevice(Device obj)
        {
            if (theNumbersOfFreePort < TheNumbersOfPort)
            {
                DeviseSection.Add(obj);
                theNumbersOfFreePort += 1;
                if(theNumbersOfFreePort == TheNumbersOfPort && AllDeviceRemove != null)
                    AllDeviceRemove(this, EventArgs.Empty);
            }
            else
            {
                throw new Exception("You can not add a device, there are no available ports.");
            }
        }
        public void RemoveDevice(Device obj)
        {
            if (theNumbersOfFreePort >= 1)
            {
                DeviseSection.Remove(obj);
                theNumbersOfFreePort -= 1;
                if (theNumbersOfFreePort == 0 && AllDeviceConnected != null)
                    AllDeviceConnected(this, EventArgs.Empty);
            }
            else
            {
                throw new Exception("You can not remove the device, as there is no connected devices.");
            }
        }
        public event EventHandler AllDeviceRemove;
        public event EventHandler AllDeviceConnected;
    }
}
