using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodChain
{
    public abstract class OrderItemLeaf : IOrderItem
    {
        private double Price;
        private string Name;
        public OrderItemLeaf(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string GetName()
        {
            return Name;
        }
        public double GetPrice()
        {
            return Price;
        }
    }
}
