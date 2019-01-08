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
                Console.Write("Enter Customer Name:  ");
                var cusName = Console.ReadLine();
                var name = vehInfo.GetCusName(cusName);

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
                            GetVehData(vehCategs, name);//Database--factory class is processing user data

                            break;
                        
                        }
                       
                    case VehCate.Sedan:
                        {
                            GetVehData(vehCategs, name);
                            break;
                        }
                    case VehCate.Truck:
                        {
                            
                            GetVehData(vehCategs, name);
                            break;
                        }

                    case VehCate.Print:// Search customer's requests by Name, if one or more queries have been requested
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("**********************Vehicle Selection History for Customer**************************");
                            //Console.WriteLine(vehInfo.CusName);
                            //var name = vehInfo.CusName;

                            //var mCake = vehInfo.VehCategs;
                            //var make = vehInfo.Make;

                            var searches = VehFactory.GetVehicInfos(vehInfo.CusName);
                            foreach (var Search in searches)
                            {
                                //Console.WriteLine("what DA");
                                Console.WriteLine($" Name:  {Search.CusName} Category: {Search.VehCategs}   Make: {Search.Make}   Color: {Search.Color}   Model: {Search.Model}   Type: {Search.TypeC} ");
                            }
                            Console.ResetColor();
                            break;
                        }


                    case VehCate.All: //Returns all of the requests by the customers
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("**********************Vehicle Selection History**************************");
                        
                        var allSearches = VehFactory.GetVehicInfos();
                        foreach (var Search in allSearches)
                        {
                            //Console.WriteLine("what DA");
                            Console.WriteLine($" Name:  {Search.CusName} Budget: {Search.Budget} Category: {Search.VehCategs}   Make: {Search.Make}   Color: {Search.Color}   Model: {Search.Model}   Type: {Search.TypeC} ");
                        }
                        Console.ResetColor();
                        break;


                    //case VehCate.CusRecord:
                    //    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    //    Console.WriteLine("**********************Custom Record**************************");
                    //    Console.ResetColor();

                    //    Console.BackgroundColor = ConsoleColor.Blue;
                                                                

                    //    var csearch = VehFactory.GetVehRelations();

                    //    foreach (var Search in csearch)
                    //    {

                    //        Console.WriteLine($" Name:  {Search.CusName} Category: {Search.Categories}   Date: {Search.CusRecDateTime}   Budget: {Search.Budget:C} ");
                    //    }

                    //    Console.ResetColor();

                        break;


                    default:
                                Console.WriteLine("What happened");
                                break;
                }
            }

        }

        private static void GetVehData(VehCate x, string name)
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


            vehInfo.Tes(cmakes, x);//Elantra, Tuson, F150, F250, Rio, Rio5
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
            Console.WriteLine("Select Color: ");

            var vehcolor = Enum.GetNames(typeof(VehColor)); //
            for (var i = 0; i < vehcolor.Length; i++)
            {
                Console.Write($" {i + 1 }. {vehcolor[i]}     ");
            }
            
            Console.WriteLine();
                        
            Console.ResetColor();

            Console.Write("You've selected: ");

            var cColor = Convert.ToInt32(Console.ReadLine());
            var cColors = (VehColor)Enum.Parse(typeof(VehColor), vehcolor[cColor - 1]);

            var Vcolor = new [] { "White", "Red", "Blue", "Black", "Gray" };
            if (cColors == VehColor.Black)
            {

                var tColor = "Black";
                

                vehInfo.CusColor(tColor);
            }

            Console.Write("Enter Customer's Budget:  ");
            var cusbud =  Convert.ToDecimal (Console.ReadLine());
            
            //VehFactory.CustomerRecord(name, x, cusbud);
            var ntest = VehFactory.VehHistory(cate: x, color: cColors, name: name, make: cmakes, model: model);






        }
    }
}
