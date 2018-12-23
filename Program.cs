using System;

namespace VehicalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehInfo = new VehicInfo();//Create an object to use properties and methods
            

            Console.WriteLine("Please enter Customer's vehicle requirements");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;//Color borders_____________________________________________________

                Console.Write("Please select number for catagory:");
                var vehCate = Enum.GetNames(typeof(VehCate));
                for (var i = 0; i < vehCate.Length ; i++)
                {
                    Console.Write($" {i + 1}. {vehCate[i]}     ");
                }

                Console.WriteLine();
                Console.Write("You've entered: ");
                var vehCateg = Convert.ToInt32 (Console.ReadLine());
                var vehCategs = (VehCate)Enum.Parse(typeof(VehCate), vehCate[vehCateg -1]);

                Console.ResetColor(); //Color borders_____________________________________________________


                switch (vehCategs)

                {
                    case VehCate.Exit:

                        return;

                    case VehCate.Suv:
                        {
                            GetVehData(vehCategs);

                            break;
                        
                        }
                       
                    case VehCate.Sedan:
                        {
                            GetVehData(vehCategs);

                            break;
                        }
                    case VehCate.Truck:
                        {
                            GetVehData(vehCategs);
                            break;
                        }

                    case VehCate.Print:
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("**********************Vehicle Selection History**************************");
                            var searches = VehFactory.GetVehicInfos();
                            foreach (var Search in searches)
                            {
                                                           
                                Console.WriteLine($" Category: {Search.VehCategs}   Make: {Search.Make}   Color: {Search.Cselect}   Model: {Search.Model}   Type: {Search.TypeC} ");
                            }
                            Console.ResetColor();
                            break;
                        }

                            default:
                                Console.WriteLine("What happened");
                                break;
                }

            


            }

        }

        public static void GetVehData(VehCate vehCategs)
        {
            var vehInfo = new VehicInfo();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Please select make number: ");
            var vehmake = Enum.GetNames(typeof(VehMake)); //Hyundai, Ford, Kia
            for (var i = 0; i < vehmake.Length; i++)
            {
                Console.Write($" {i + 1 }. {vehmake[i]}     ");
            }
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("You've entered: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            var cmake = Convert.ToInt32(Console.ReadLine());
            var cmakes = (VehMake)Enum.Parse(typeof(VehMake), vehmake[cmake - 1]);


            vehInfo.Tes(cmakes, vehCategs);//Elantra, Tuson, F150, F250, Rio, Rio5
            var model = vehInfo.Model;
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (string str in Enum.GetNames(typeof(VehType)))//Manual, Automatic, TwoWheelDrv, FrWheelDrv
                Console.Write(str + ":  ");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("You've entered: ");
            var cusType = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select Color (Case Sensitive): Red, Gray, and Black");
            Console.ResetColor();

            Console.Write("You've entered: ");
            var Vcolor = Console.ReadLine();
            vehInfo.CusColor(Vcolor);


            var vehFactory = VehFactory.VehHistory(vehCategs, cmakes, model: model, color: Vcolor);


        }
    }
}
