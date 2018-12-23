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
       

        public static VehicInfo VehHistory(VehCate cate, VehMake make, [Optional]string model, [Optional] VehType ctype, [Optional]string color )
        {
           

            var vehistory = new VehicInfo
            {
                VehCategs = cate,
                Make = make,
                Model = model,
                Cselect = color 
                     
            };

            vInvent.Add(vehistory);
            return vehistory;
        }

        public static IEnumerable<VehicInfo> GetVehicInfos()
        {
            return vInvent;

        }

    }
}
