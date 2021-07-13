using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning5
{
    public class GarageHandler
    {
        //private string regno;
        
        public Garage<Vehicle> garage { get; private set; }


        public GarageHandler(int size)
        {
            garage = new Garage<Vehicle>(size);
            //            InitSomeVehicles();

 //           var slask = new UserInput(regno);
            


            //           int inx = Garage<Vehicle>.Gfetch(regno);
            //           inx = new Gfetch(regno);
            Console.WriteLine();

        }

        

        public void Unpark(string regno)
        {
            int inx = garage.Gfetch(regno);
        }

        public void InitV()
        {
            garage.InitSomeVehicles();
        }


        public static void GHandler()
        {



        }
    }
}
