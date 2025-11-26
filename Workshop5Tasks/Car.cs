using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5Tasks
{
    class Car : Vehicle
    {
        public int Seats { get; set; } = 0; // initialize to avoid null issues

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Seats: {Seats}");
        }
    }


}
