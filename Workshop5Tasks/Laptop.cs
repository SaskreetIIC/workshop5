using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5Tasks
{
    class Laptop : ElectronicDevice
    {
        public Laptop(string brand, double price) : base(brand, price) { }

        public void TurnOnBattery()
        {
            Console.WriteLine("Laptop battery is turned on");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop Brand: {Brand}, Price: {Price}");
        }
    }
}
