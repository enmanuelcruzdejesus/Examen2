using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2

{
    class MicroUSBPort
    {
        USBCableMicro _cable;
        public MicroUSBPort() { }
        public void PlugCable(USBCableMicro cable)
        {
            _cable = cable;
            Console.WriteLine("Connecting USB CABLE into MicroUSBPort");
        }
    }
}
