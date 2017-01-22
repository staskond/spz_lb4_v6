using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_V5
{
    class DeviceManager
    {
        List<Computer> listComputer = new List<Computer>();
        List<Device> listDevice = new List<Device>();
        public uint AllComputers { get; private set; }
        public uint AllDeivce { get; private set; }
        private uint NotUsedDevice;
        public void AddComputer(Computer obj)
        {
            listComputer.Add(obj);
        }
        public void DeleteComputer(Computer obj)
        {
            listComputer.Remove(obj);
        }

}
