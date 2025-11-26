using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5Tasks
{
    class BikeAbs : VehicleAbs
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Bike engine stopped");
        }
    }
}
