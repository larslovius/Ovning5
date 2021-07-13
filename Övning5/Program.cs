using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning5
{
    class Program
    {
        static void Main(string[] args)
        {
            //           Console.WriteLine("How many places for vehicles i this garage?");
            //          int Np = int.Parse(Console.ReadLine());
            //           var garage = new GarageHandler(Np);
            var  man = new Manager();
            man.Manag();
        }

 
    }
}
