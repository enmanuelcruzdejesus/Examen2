
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2
{
    class USBTypeCPort
    {
        USBTypeCCable _cable;
        public USBTypeCPort() { }
        public void PlugCable(USBTypeCCable cable)
        {
            _cable = cable;
            Console.WriteLine("Connecting USBCABLE into USBTypeCPort");
        }
    }
}
