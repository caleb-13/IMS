using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inventory_Management_System.Models
{
    internal class Outsourced : Part
    {

        public string CompanyName { get; set; }


        public Outsourced(int partID, string name, double price, int inStock, int min, int max, string companyName)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }

       
    }
}
