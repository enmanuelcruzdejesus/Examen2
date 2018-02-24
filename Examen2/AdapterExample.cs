using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2
{
    /* Adaptee (source) interface */
    interface IEuropeanSocket
    {
        int voltage();
        int live();
        int neutral();
        int earth();
    }

    /* Adaptee */
    class EuroSocket : IEuropeanSocket
    {
        public int voltage() { return 220; }

        public int live() { return 1; }
        public int neutral() { return -1; }
        public int earth() { return 0; }


    }

    /* Target interface */
    interface IUSASocket
    {
        int voltage();
        int live();
        int neutral();
    }

    /* The Adapter */
    class Adapter : IUSASocket
    {
        IEuropeanSocket _socket;
        public void Plugin(IEuropeanSocket outlet) { _socket = outlet; }
        public int voltage() { return 110; }
        public int live() { return _socket.live(); }
        public int neutral() { return _socket.neutral(); }
    }

    /* Client */
    class Iphone
    {
        static string _model = "";
        USBTypeCPort _input;
        IUSASocket _socket;

        public Iphone()
        {
            _input = new USBTypeCPort();
        }
        public void PlugCable(USBTypeCCable cable)
        {
            _input.PlugCable(cable);
        }

        public void Plugin(IUSASocket supply)
        {
            _socket = supply;
        }

        public void Charge()
        {
            if (_socket.voltage() > 110)
                Console.WriteLine("Iphon is on fire");

            Console.WriteLine("Charging");
        }


    }

    class SamSung
    {
        MicroUSBPort _input;
        IUSASocket _socket;
        public SamSung() { _input = new MicroUSBPort(); }
        void PlugCable(USBCableMicro cable)
        {
            _input.PlugCable(cable);
        }
        public void Plugin(IUSASocket supply)
        {
            _socket = supply;
        }

        public void Charge()
        {
            if (_socket.voltage() > 110)
                Console.WriteLine("Samsung is on fire");

            Console.WriteLine("Charging");
        }


    }



}
