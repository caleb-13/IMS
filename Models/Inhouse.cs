using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    internal class Inhouse : Part
    {


        public Inhouse(int partID, string name, double price, int instock, int min, int max, int machineID)
        {
            PartID = partID;    
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
            MachineID = machineID;
        }

       
    }
           
    
    
}

