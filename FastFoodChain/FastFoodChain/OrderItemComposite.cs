using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodChain
{
    public abstract class OrderItemComposite : IOrderItem
    {
        protected List<IOrderItem> OrderItems;
        private string Name;
        public OrderItemComposite(string name)
        {
            Name = name;
            OrderItems = new List<IOrderItem>();
        }
        public string GetName()
        {
            string totalName = $"{Name}: ";
            foreach (var item in OrderItems)
            {
                totalName += $"{item.GetName()}, ";
            }
            return totalName;
        }

        public virtual double GetPrice()
        {
            double totalPrice = 0;
            foreach (var item in OrderItems)
            {
                totalPrice += item.GetPrice();
            }
            return totalPrice;
        }

        public virtual void AddOrderItem(IOrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }
    }
}
