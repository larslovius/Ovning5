using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning5
{
    public class  Garage<T> // : IEnumerable<T>
    {
        //private T[] vehicle;
        private Vehicle[] vehicles;
        public int Nplaces { get; private set; }    //The maximum capacity of the garage
        private int Nvehicle = 0;   //Actual number of viechles parked in the garaGE

        //       public void SetupGarage(T vehicle)
        public Garage(int size)
        {
            vehicles = new Vehicle[size];
            Nplaces = size;
            InitSomeVehicles();
        }

        public int Gfetch(string regno)
        {
            Console.WriteLine(vehicles[0]);
            Console.WriteLine(vehicles[1]);
   

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i].RegNo == regno)
                {                               // Target vehicle found
                    vehicles[i].RegNo = null;    // Mark as fetched by erasing mandatory reg no 
                    Nvehicle--;                 // One place freed
                    return i;                   // Return released array element
                }
            }
            return -1;
 //           while (i < Nvehicle && vehicles[i].RegNo != regno) i++;
 ////           while (i < Nvehicle ) i++;
 //           if (vehicles[i].RegNo == regno)
 //           {                               // Target vehicle found
 //               vehicles[i].RegNo = null;    // Mark as fetched by erasing mandatory reg no 
 //               Nvehicle--;                 // One place freed
 //               return i;                   // Return released array element
 //           }
 //           else
 //           {
 //               return -1;                   // Vehicle not found -> return bad array index
	//        }
        }

 //       public bool Gpark(int ix, T newVehicle)
        public bool Gpark(int ix, Vehicle newVehicle)

        {
           if (ix < Nplaces && vehicles[ix] == null)
           {
                vehicles[ix] = newVehicle;
                Nvehicle++;
                return true;
           }
           else
           {
                return false;
           }
        }

        public void InitSomeVehicles()
        {
            var car = new Car();
            car.NoOfWheels = 4;
            car.Brand = "Volvo";
            car.RegNo = "ABC123";
            car.Colour = "blue";
            car.FuelType = "Gasolin";
            vehicles[0] = car;

            var bus = new Bus();
            bus.NoOfWheels = 4;
            bus.Brand = "Scania";
            bus.RegNo = "DEF456";
            bus.Colour = "green";
            bus.NoOfSeats = 30;
            vehicles[1] = car;

        }



    }
}
