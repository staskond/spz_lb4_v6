using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_V5
{
    class Device
    {
        public enum eDeviceType
        {
            Mouse,
            Keyboard,
            HDD,
            RAM,
            Printer,
            Scanner,
            Phone,
            Flash,
            Monitor,
            Microphone,
            Headphones
        }
        public enum ePortType
        {
            COM,
            USB,
            MicroUSB
        }
        public string Name { get; private set; }
        public string Manufacturer { get; private set; }
        public eDeviceType DeviceType { get; set; }
        public ePortType PortType { get; set; }

        public Device(string _name, string _manufecturer, eDeviceType _deviceType, ePortType _portType)
        {
            Name = _name;
            Manufacturer = _manufecturer;
            DeviceType = _deviceType;
            PortType = PortType;
        }
        public Device(Device _obj)
        {
            Name = _obj.Name;
            Manufacturer = _obj.Manufacturer;
            DeviceType = _obj.DeviceType;
            PortType = _obj.PortType;
        }


    }
}
