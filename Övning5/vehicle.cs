using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning5   
{
    //Interface
    //En klass kan implementera (ärva) från många interface
    //Allt är publikt
    //(Med C# 8 kan vi har privata statiska medlemmar, samt privata metoder med default implemenation)
    //Måste Implementeras i ärvda klasser
    //(Kan ha implementation from c# 8)
    //Kan inte implementeras - ej skapa objekt av med new
    /*

    public interface IDrivable
    {
        string Drive(double distance);
    }

    */
    //Abstrakt
    //Kan inte implementeras - ej skapa objekt av med new
    //Kan inehålla en blandnig av vanliga metoder och abstrakta metoder utan implementation
    //Alla abstrakta medlemmar måste implemneteras av dem som ärver från den abstrakta klassen
    //Kan hålla privata fält
    public abstract class AbstractVehicle //: IDrivable
    {
        //Virtual - En metod som markeras med nykelordet virtual är ok att skriva en ny implementation i  ärvda klasser
        /*

        public virtual string Drive(double distance)
        {
            return $"{this.GetType().Name} wants to drive for {distance}";
        }

        public void Do()
        {
            Console.WriteLine("Hej");
        }

        //Håller ingen implementation måste implementeras i ärvda klasser
        public abstract string Turn();
        
        */
    }

    //Vehicle ärver från AbstractVehicle
    public class Vehicle : AbstractVehicle
    {
        public int NoOfWheels;
        public string Brand { get; set; }
        public string RegNo { get; set; }
        public string Colour { get; set; }


        //regno har ett defaultvärde om vi inte skickar in något blir regno "Abc123"

        //   public Vehicle(string brand, string regno = "Abc123")
        public Vehicle()
        {
//            Brand = brand;
 //           RegNo = regno;

        }
        /*
        public override string Drive(double distance)
        {
            base.Drive(23);
            return "Hej";
        }

        //Overide egen implementation av Turn
        public override string Turn()
        {
            return "Vehicle turns";
        }
        */
        //Nyckelordet sealed låser metoden från att overriadas längre
        //public sealed override string Drive(double distance)
        //{
        //    return base.Drive(distance);
        //}
    }

    public class Airplane : Vehicle
    {
        //Privat fält
        private int noOfEngines;

        //Property, när vi skriver kod i get och set behöver vi skriva ut det bakomliggande fältet
        /*
         * 
        public double FuelLevel
        {
            get
            {
                return fuelLevel;
            }
            set
            {
                double newLevel = Math.Max(0, value);
                fuelLevel = Math.Min(newLevel, Fuelcapacity);
            }
        }

        //Property med enbart geter
        public double Fuelcapacity { get; }

        //Konstruktor, base i det här fallet Vehicle, Vi anropar Vehicles konstruktor
        public FuelVehicle(string brand, string regNo, double fuelcapacity) : base(brand, regNo)
        {
            Fuelcapacity = fuelcapacity;
        }

*/
    }

    public class Motorcycle : Vehicle
    {

        private int cylinderVolume;
/*

        //Const kan inte ändras när värdet är satt. Måste sätta värdet direkt!
        private const double fuelConsumption = 0.5;
        public double MaxDistance // => FuelLevel / fuelConsumption;
        {
            get
            {
                return FuelLevel / fuelConsumption;
            }
        }

        //Kedjade konstruktorer. base anropar basklassens konstruktor, this anropar den andra konstruktorn i klassen
        public FuelCar() : this("DefaultBrandName", 100, "XXX555") { }

        public FuelCar(string brand, double fuelcapacity, string regno) : base(brand, regno, fuelcapacity) { }

        public override string Drive(double distance)
        {
            var result = new StringBuilder();

            result.AppendLine(base.Drive(distance));

            if (distance < 0)
            {
                distance = 0;
                result.AppendLine("Negative distance is assumed to be 0");
            }

            //FuelLevel = FuelLevel - (distance * fuelConsumption);
            FuelLevel -= distance * fuelConsumption;

            result.AppendLine($"RegNo: {RegNo} drove {distance} km");

            return result.ToString();
        }

        public string Sound() => "Tut tut Greta!";
        //{
        //    return "Tut tut";
        //}*/
    }
    public class Car : Vehicle
            {
                public string FuelType;
            }

    public class Bus : Vehicle
            {
                public int NoOfSeats;
            }

    public class Boat : Vehicle
            {
                public float LenBoat;
            }
/*
    public class Bicycle : AbstractVehicle
    {
        public override string Turn()
        {
            return "Bicycle turns";
        }
        public override string Drive(double distance)
        {
            return "Bicycle starts pedaling";
        }
    }
*/
}
