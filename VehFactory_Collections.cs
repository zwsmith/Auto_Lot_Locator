using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;

namespace VehicalApp
{
    public static class VehFactory
    {
        private static List<VehicInfo> vInvent = new List<VehicInfo>();
        //private static VehDataBSModel db = new VehDataBSModel(); //Reference to created database 

        //public static VehicInfo VehHistory(string name, VehCate cate)
        public static VehicInfo VehHistory(string name, VehColor color, [Optional] VehCate cate, [Optional] VehMake make, [Optional] string model)
        {


            var vehistory = new VehicInfo
            {
                VehCategs = cate,
                CusName = name,
                Make = make,
                Model = model,
                Color = color,

            };

            vInvent.Add(vehistory);
            //db.VehicInfos.Add(vehistory);
            //db.SaveChanges();
            return vehistory;
        }

        public static IEnumerable<VehicInfo> GetVehicInfos(string name)
        {

            //return db.VehicInfos.Where(a => a.CusName == name);
            return vInvent.Where(a => a.CusName == name);

        }
        public static IEnumerable<VehicInfo> GetVehicInfos()
        {
            //return db.VehicInfos;
            return vInvent;
        }

        //public static void CustomerRecord(string name, VehCate cate, decimal budget)
        //{
        //    var cusname = vInvent.SingleOrDefault(a => a.CusName == name);
        //    //var cusname = db.VehicInfos.SingleOrDefault(a => a.CusName == name);
        //    //cusname.CusBudget(budget);

        //    var vehrelation = new VehRelation()
        //    {
        //        CusRecDateTime = DateTime.Now,
        //        CusName = name,
        //        Categories = cate,
        //        Budget = budget,
                                             
        //    };

                 
        //    //db.VehRelations.Add(vehrelation);

        //    //db.SaveChanges();
        //}
    
        //public static IEnumerable<VehRelation> GetVehRelations()
        //{
        //    return db.VehRelations;
                
        //}
    }
}
