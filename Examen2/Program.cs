using System;

namespace Examen2
{
    class Program
    {
        static void Main(string[] args)
        {
            EuroSocket socket = new EuroSocket();
            Adapter adp = new Adapter();
            Iphone phone = new Iphone();
            phone.PlugCable(new USBTypeCCable());

            //conecting the adapter into the European socket
            adp.Plugin(socket);

            //connecting the phone into USA socket
            phone.Plugin(adp);

            //charging the phone
            phone.Charge();

            Console.ReadLine();
        }
    }
}
