using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosLayer
{
    public class Customers
    {
        //// Campo privado (backing field)
        //private string companyName;

        //// Propiedades con getter y setter
        //public string CompanyName
        //{
        //    get { return companyName; }
        //    set { companyName = value; }
        //}

        //public class Empresa
        //{
        //    // Propiedad automática
        //    public string CompanyName { get; set; }
        //}

        public String CompanyName { get; set; }
        public String ContactName { get; set; }
        public String ContactTitle { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String Region { get; set; }
        public String PostalCode { get; set; }
        public String Country { get; set; }
        public String Phone { get; set; }
        public String Fax { get; set; }
    }
}
