using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasMembuatClassTaxi
{
    class Taxi
    {
        // Propoties
        public String DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        // Method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("OnDuty : YES");
            } else
            {
                Console.WriteLine("OnDuty : NO");
            }
            Console.WriteLine("Number of Passenger : {0}\n\n", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang\n", DriverName);
        }
    }
}
