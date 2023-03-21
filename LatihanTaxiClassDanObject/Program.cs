using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaxiDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Taxi
            Class taxi = new Class();

            // pengertian nilai properties
            taxi.DriverName = "Gilang";
            taxi.OnDuty = true;
            taxi.NumPassanger = 10;

            // pemanggil method

            taxi.TaxiInfo();
            if (taxi.OnDuty == true)
            {
                taxi.PickUpPassanger();
            }

            else if (taxi.OnDuty == false)
            {
                taxi.DropOffPassanger();
            }
            Console.ReadKey();

        }
    }
}
