using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodChain
{
    public class SimpleMealComposite : OrderItemComposite
    {
        public SimpleMealComposite() : base("Simple meal")
        {
            OrderItems.Add(new SodaOrderItemLeaf());
            OrderItems.Add(new IceCreamOrderItemLeaf());
        }
    }
}
