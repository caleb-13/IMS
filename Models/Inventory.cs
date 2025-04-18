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

        static public Product CurrentPrdouct { get; set; }
        static public Part CurrentProduct { get; set; } 
        static private int PartID { get; set; }
        static private int ProductID { get; set; }

        private static int nextID = 4;



        static Inventory()
        {
            addProduct(new Product(1, "Drill", 10.00, 10, 1, 100));
            addProduct(new Product(2, "radio", 20.00, 20, 1, 200));
            addProduct(new Product(3, "Engine", 30.00, 30, 1, 300));
            addPart(new Inhouse(1, "Drill Bit", 1.00, 10, 1, 100, 1));
            addPart(new Inhouse(2, "Speaker", 2.00, 20, 1, 200, 2));
            addPart(new Outsourced(3, "Coil", 3.00, 30, 1, 300, "Auto Industry"));
            PartID = 4; // Start at 4 because we added 3 parts
            ProductID = 4; // Start at 4 because we added 3 products
        }

        public static int GenerateNextID()
        {
            return nextID++;
        }

        public static int generateProductID()
        {
            try
            {
                return ProductID++;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static void addPart(Part part)
        {
            Allparts.Add(part);
        }
        public int lookupProduct(Product product)
        {
            return product.ProductID;
        }




        public static void addProduct(Product product) 
        { 
            Products.Add(product); 
        }
        public static bool removeProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    Products.Remove(product);
                    return true;
                }
            }
            return false;
        }

        public static Product lookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }

        public static void updateProduct(int productID, Product product)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products[i] = product;
                    break;
                }

            }
        }

        public static bool removePart(Part part)
        {
            foreach (Part p in Allparts)
            {
                if (p.PartID == part.PartID)
                {
                    Allparts.Remove(p);
                    return true;
                }
            }
            return false;
        }

        public static Part lookupPart(int partID)
        {
            foreach (Part part in Allparts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
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
