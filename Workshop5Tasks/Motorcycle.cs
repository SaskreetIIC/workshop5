using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5Tasks
{
    class Motorcycle : Vehicle
    {
        public string Type { get; set; } = ""; // initialize string to avoid null warnings

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: {Type}");
        }
    }

}
