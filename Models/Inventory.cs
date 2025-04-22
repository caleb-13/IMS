using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Inventory_Management_System.Models
{
    
    internal class Inventory
    {
        static public BindingList<Product> Products { get; set; } = new BindingList<Product>();
        static public BindingList<Part> Allparts { get; set; } = new BindingList<Part>();

      
        private static int nextProductID = 4; 

        private static int nextPartID = 4;



        static Inventory()
        {
            addProduct(new Product(1, "Drill", 10.00, 10, 1, 100));
            addProduct(new Product(2, "radio", 20.00, 20, 1, 200));
            addProduct(new Product(3, "Engine", 30.00, 30, 1, 300));
            addPart(new Inhouse(1, "Drill Bit", 1.00, 10, 1, 100, 1));
            addPart(new Inhouse(2, "Speaker", 2.00, 20, 1, 200, 2));
            addPart(new Outsourced(3, "Coil", 3.00, 30, 1, 300, "Auto Industry")); 
        }

        public static int GenerateNextID()
        {
            return nextPartID++;
        }

        public static int generateProductID()
        {
            return nextProductID++;
        }

        public static void addPart(Part part)
        {
            Allparts.Add(part);
        }

        public static void addProduct(Product product)
        {
            Products.Add(product);
        }

        public static void updatePart(int partID, Part part)
        {
            for (int i = 0; i < Allparts.Count; i++)
            {
                if (Allparts[i].PartID == partID)
                {
                    Allparts[i] = part;
                    break;
                }
            }
        }
    }
}
