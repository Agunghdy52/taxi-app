using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi_app
{

    internal class Program
    {
        static void Main()
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "Agung Hidayat";
            taxi.OnDuty = true;
            taxi.NumPassanger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOffPassanger();

            Console.ReadKey();
        }
    }
}
