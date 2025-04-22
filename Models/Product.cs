using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inventory_Management_System.Models
{
    internal class Product 
    {
        public static BindingList<Part> AssociatedParts { get; set; }  = new BindingList<Part> {};

        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int InStock { get; set; }
        public int Min {  get; set; }
        public int Max { get; set; }

        public Product(int productID, string name, double price, int inStock, int min, int max)
        {
            AssociatedParts = new BindingList<Part>();
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part); 
        }


        public bool removeAssociatedPart (int partID) 
        { 
            Part part = lookupAssociatedPart(partID);
            if (part != null)
            {
                AssociatedParts.Remove(part);
                return true;
            }
            return false;
        }

        public Part lookupAssociatedPart(int partID)
        {
            return AssociatedParts.Where(part => part.PartID == partID)
                                  .FirstOrDefault();
        }

        public override string ToString()
        {
            {
                return Name;
            }
        }

    }
    
}
