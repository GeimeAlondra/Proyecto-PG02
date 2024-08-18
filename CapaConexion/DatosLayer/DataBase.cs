using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosLayer
{
    public class DataBase
    {
        public static String ConnectionString
        {
            get
            {
                return ConfigurationManager
                .ConnectionStrings["NWConnection"]
                .ConnectionString;
            }
        }

        //public static String ConnectionString1()
        //{
        //    return ConfigurationManager
        //    .ConnectionStrings["NWConnection"]
        //    .ConnectionString;
        //}
    }
}
