using System;

namespace FastFoodChain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MainMealComposite mainMeal = new MainMealComposite();
            mainMeal.AddOrderItem(new SodaOrderItemLeaf());
            mainMeal.AddOrderItem(new SodaOrderItemLeaf());
            mainMeal.AddOrderItem(new IceCreamOrderItemLeaf());
            Console.WriteLine(mainMeal.GetPrice());
            mainMeal.AddOrderItem(new SimpleMealComposite());
            Console.WriteLine(mainMeal.GetPrice());
            Console.WriteLine(mainMeal.GetName());
        }
    }
}
