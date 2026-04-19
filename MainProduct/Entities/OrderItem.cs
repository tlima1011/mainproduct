using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MainProduct.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; } 

        public OrderItem()
        {

        }
        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product; 
        }

        public double subTotal()
        {
            return Quantity * Product.Price; 
        }

        public override string ToString()
        {
            return "Product:\nName: " + Product.Name 
                + "\nQuantity: " + Quantity 
                + "\nUnity Price $" + Product.Price.ToString("F2", CultureInfo.InvariantCulture)
                + "\nSubtotal: $" +subTotal().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
