using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning5
{
    public class Manager
    {
        static string regno;

        public void Manag()
        {
            Console.WriteLine("How many places for vehicles i this garage?");
            int Np = int.Parse(Console.ReadLine());
            var garage = new GarageHandler(Np);
            garage.InitV();
            //           var slask = new UserInput(regno);
            string rep;
            while (true)
            {
                Console.WriteLine("Welcome to Lars' garage! Fetch or Park a vehicle <F/P> Qiut<Q>?");
                do
                {
                    rep = Console.ReadLine();
                } while (rep != "F" && rep != "P");
                if (rep == "F")
                {
                    Console.WriteLine("Please type the registration number");
                    regno = Console.ReadLine();
                    //               regno = tmp.ToUpper;

                    garage.Unpark(regno);
                }
                else if (rep == "P")
                {
                    Console.WriteLine();
                }
                else if (rep == "Q")
                    break;
            }
        }

  //      public void RunGarage()
  //      {
  //          Garage.Gfetch(regno);
  //      }
    }
}
