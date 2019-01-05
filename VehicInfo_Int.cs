using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace VehicalApp
{
    public  enum VehCate { Exit,Suv,Sedan,Truck,Print, All, CusRecord};
    public enum VehType { Manual, Automatic, TwoWheelDrv, FrWheelDrv };
    public enum VehFeatures { AirCondition, AutoWindows, PustStart };
    public enum VehColor { White, Red, Blue, Black, Gray };
    public enum VehMake { Hyundai, Ford, Kia };
    public enum VehModel { Elantra, Tuson, F150, F250, Rio, Rio5 };

    /// <summary>
    /// Defines all properties of a vehicle
    /// </summary>

    public class VehicInfo
    {
        private string _cusName;
        private decimal _budget;

        public VehCate VehCategs { get; set; }
        public VehType TypeC { get; set; } //*What Type-Property

        public VehMake Make { get; set; } //*What Make

        public string Model { get; set; } //*What Model

        public VehColor Color { get; set; } //*What Color
        public string Cselect { get; set; }

        public string CusName { get => _cusName; set => _cusName = value; }
        //public VehFeatures Features { get; set; } //*What Features

        public decimal Budget { get => _budget; set => _budget = value; } //*What's their budget
        public virtual ICollection<VehRelation> VehRelations { get; set; }



        public void Tes(VehMake Cmake, VehCate category)

        {


            if (Cmake == VehMake.Ford && VehCate.Truck == category)
            {
                Console.WriteLine("Please Select: F150 or F250");
                Console.Write("You've entered: ");
                var makeInven = Console.ReadLine();
                Model = makeInven;
            }

            if (Cmake == VehMake.Ford && VehCate.Suv == category)
            {
                Console.WriteLine("Please Select: EcoSport, Edge, or Escape");
                Console.Write("You've entered: ");
                var makeInven = Console.ReadLine();
                Model = makeInven;
            }

            if (Cmake == VehMake.Ford && VehCate.Sedan == category)
            {
                Console.WriteLine("Please Select: Fiesta, Focus, or Taurus");
                Console.Write("You've entered: ");
                var makeInven = Console.ReadLine();
                Model = makeInven;
            }
            if (Cmake == VehMake.Kia && VehCate.Suv == category)
            {
                Console.WriteLine("Please Select: Niro, Sorento, or Sportage");
                Console.Write("You've entered: ");
                var makeInven = Console.ReadLine();
                Model = makeInven;
            }

            if (Cmake == VehMake.Kia && VehCate.Sedan == category)
            {
                Console.WriteLine("Please Select: Cadenza, Forte, Optima");
                Console.Write("You've entered: ");
                var makeInven = Console.ReadLine();
                Model = makeInven;
            }
            if (Cmake == VehMake.Hyundai && VehCate.Suv == category)
            {
                Console.WriteLine("Please Select: Tuscon, Kona, Santa Fe");
                Console.Write("You've entered: ");
                var makeInven = Console.ReadLine();
                Model = makeInven;
            }

            if (Cmake == VehMake.Hyundai && VehCate.Sedan == category)
            {
                Console.WriteLine("Please Select: Accent, Elantra, or Sonata");
                Console.Write("You've entered: ");
                var makeInven = Console.ReadLine();
                Model = makeInven;
            }

            if (Cmake == VehMake.Hyundai && VehCate.Truck == category || Cmake == VehMake.Kia && VehCate.Truck == category)
            {
                Console.WriteLine("Sorry, Ford is the make that has truck models");
            }
        }

        public void CusColor([Optional]string Vcolor)
        {


            switch (Vcolor)

            {

                case "Red":
                    {
                        Console.WriteLine("ON ORDER");
                        Cselect = Vcolor;

                        break;
                    }

                case "Black":
                    {
                        Console.WriteLine("OUT OF STOCK:");
                        Cselect = Vcolor;
                        break;
                    }

                case "Gray":
                    {
                        Console.WriteLine("IN STOCK");
                        Cselect = Vcolor;
                        //Console.ReadKey();
                        break;
                    }

                default:
                    Console.WriteLine("Oh No");
                    break;
            }

        }


        public string GetCusName(string name)
        {
            CusName = name;
            return _cusName;
        }

        public decimal CusBudget (decimal cusB)
        {
            _budget = cusB;
            return _budget;
        }
    }

}
