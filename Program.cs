using System;

namespace VehicalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehInfo = new VehicInfo();//Create an object to use properties and methods
            

            Console.WriteLine("Hello World!");

            Console.WriteLine("What type (Case Sensitive): 1-Suv, 2-Sedan, 3-Truck");
            var Ctype = Console.ReadLine();

            switch (Ctype)

            {
                case "Suv":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (string make in Enum.GetNames(typeof(VehMake)))//Hyundai, Ford, Kia 
                        Console.Write(make + ":");
                        Console.ResetColor();
                        Console.WriteLine();
                        

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string Cmake = Console.ReadLine(); 
                        vehInfo.Tes(Cmake,null, null);//foreach (string model in Enum.GetNames(typeof(VehModel)))//Elantra, Tuson, F150, F250, Rio, Rio5
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (string str in Enum.GetNames(typeof(VehType)))//Manual, Automatic, TwoWheelDrv, FrWheelDrv
                        Console.Write(str + ":  ");
                        Console.ResetColor();
                        Console.WriteLine();
                        var cusType = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Select Color (Case Sensitive): Red, Gray, and Black");
                        Console.ResetColor();
                        var Vcolor = Console.ReadLine();
                        vehInfo.CusColor(Vcolor);

                        
                        vehInfo.Print();
                        Console.WriteLine (vehInfo.Cselect); 
                        Console.WriteLine (vehInfo.Model);
                        

                        break;
                        
                    }
                       
                case "Truck":
                    {

                        foreach (string make in Enum.GetNames(typeof(VehMake)))//Hyundai, Ford, Kia 
                        Console.Write(make + ":  ");
                        Console.WriteLine();
                        string Tmake = Console.ReadLine();
                        vehInfo.Tes(null, null, Tmake);//Remember parameters are position based and must follow the sequence listed in the method
                        foreach (string str in Enum.GetNames(typeof(VehType)))//Manual, Automatic, TwoWheelDrv, FrWheelDrv
                        Console.Write(str + ":  ");
                        Console.WriteLine();
                        var cusType = Console.ReadLine();
                        
                        Console.WriteLine();
                        Console.WriteLine("Select Color (Case Sensitive): Red, Gray, and Black");
                        var Vcolor = Console.ReadLine();
                        vehInfo.CusColor(Vcolor);
                        break;
                    }
                case "Sedan":
                    {
                        foreach (string make in Enum.GetNames(typeof(VehMake)))//Hyundai, Ford, Kia 
                        Console.Write(make + ":  ");
                        Console.WriteLine();
                        string Smake = Console.ReadLine();
                        vehInfo.Tes(null, Smake, null);
                        foreach (string str in Enum.GetNames(typeof(VehType)))//Manual, Automatic, TwoWheelDrv, FrWheelDrv
                        Console.Write(str + ":  ");
                        Console.WriteLine();
                        var cusType = Console.ReadLine();
                        Console.WriteLine("Select Color (Case Sensitive): Red, Gray, and Black");
                        var Vcolor = Console.ReadLine();
                        vehInfo.CusColor(Vcolor);
                        Console.WriteLine("1 available: ");
                        //Console.ReadKey();
                        break;
                    }
                    
                default:
                    Console.WriteLine("What happened");
                    break;
            }


           


        }

    }
}
