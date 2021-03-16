using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasMembuatClassTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat Objek Taksi
            Taxi taxi = new Taxi();

            // Pengesetan NIlai Propoties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // Pengesetan Method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
