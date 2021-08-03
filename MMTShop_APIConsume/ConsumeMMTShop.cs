using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MMTShop_APIConsume
{
    class ConsumeMMTShop
    {
        //Get All Featured Products  
        public void GetAllFeaturedProducts() 
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("https://localhost:44339/api/MMTProduct/Feature"); //URI  
                Console.WriteLine(Environment.NewLine + result);
            }
        }

        //Get All Available categories   
        public void GetAllAvailableCategories ()
        {
            using (var client = new WebClient())   
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("https://localhost:44339/api/MMTProduct/Category"); //URI  
                Console.WriteLine(Environment.NewLine + result);
            }
        }

        //Get All Available Products by category 
        public void GetAllProductsByCategory (string category)
        {
            Console.WriteLine("Enter Name:");
            using (var client = new WebClient()) 
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("https://localhost:44339/api/MMTProduct/ProductsByCategory" + "?category=" + category); //URI  
                Console.WriteLine(Environment.NewLine + result);
            }
        }









    }
}
