using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace VehicalApp
{
    public enum VehType { Manual, Automatic, TwoWheelDrv, FrWheelDrv };
    public enum VehFeatures { AirCondition, AutoWindows, PustStart };
    public enum VehColor { White, Red, Blue, Black, Gray };
    public enum VehMake { Hyundai, Ford, Kia };
    public enum VehModel { Elantra, Tuson, F150, F250, Rio, Rio5 };

    /// <summary>

    /// Defines all properties and methods for a bank account

    /// </summary>
    public class VehicInfo
    {

        public VehType Type { get; set; } //*What Type-Property

        public VehMake Make { get; set; } //*What Make

        public string Model { get; set; } //*What Model

        public VehColor Color { get; } //*What Color
        public string Cselect { get; set; }
        public VehFeatures Features { get; set; } //*What Features

        string Budget { get; set; } //*What's their budget




        public void Tes([Optional]string Cmake, [Optional]string Smake, [Optional] string Tmake)

        {


            if (Tmake == "Ford")
            {
                Console.WriteLine("Please Select: F150 or F250");
                var makeInven = Console.ReadLine();
                Model = makeInven;
            }


            if (Smake == "Kia")
            {
                Console.WriteLine("Please Select: Rio or Rio5");
                var makeInven = Console.ReadLine();
                Model = makeInven;
            }


            if (Cmake == "Hyundai")
            {
                Console.WriteLine("Please Select: Elantra or Tuscon");
                var makeInven = Console.ReadLine();
                Model = makeInven;
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
        public void Print()
        {
            //var vehInfo = new VehicInfo();
            Console.WriteLine("#############################################################");
            Console.WriteLine("################# Results from Query ########################");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Cselect}");
            Console.WriteLine("#############################################################");
            Console.WriteLine("#############################################################");

        }

    }

}
