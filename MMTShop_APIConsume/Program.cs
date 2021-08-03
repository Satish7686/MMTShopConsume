using System;

namespace MMTShop_APIConsume
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumeMMTShop product = new ConsumeMMTShop();
            product.GetAllFeaturedProducts();
            product.GetAllAvailableCategories();
            product.GetAllProductsByCategory("Home");

        }
    }
}
