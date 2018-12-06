using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;

namespace VehicalApp
{
    public static class VehFactory
    {
        //private static List<VehicInfo> vInvent = new List<VehicInfo>();

        public static VehicInfo VehHistory( string model, [Optional] VehType ctype, [Optional]VehMake make )
        {
            if (string.IsNullOrEmpty(model))
            {
                throw new ArgumentException("Please enter model", nameof(model));
            }

            var vehistory = new VehicInfo
            {
                TypeC = ctype,
                Make = make,
                Model = model 
                     
            };

            return vehistory;
        }

        
    }
}
