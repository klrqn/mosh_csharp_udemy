using System;

namespace control_flow
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCustomer = true;
            
            // float price;
            // if (isCustomer)
            //     price = 20.01f;
            // else
            //     price = 29.00f;
            
            float price = (isCustomer) ? 20.01f : 29.00f;
            
            Console.WriteLine(price);
            
            // =========== SEASONS =============
            
            var season = Season.Spring;
            
            switch (season) 
            {
                case Season.Autumn:
                    Console.WriteLine("it's beautiful fall mofo");
                    break;
                case Season.Summer:
                    Console.WriteLine("...beach!");
                    break;
                    
                case Season.Winter:
                case Season.Spring:
                    Console.WriteLine("Double case");
                    break;
                
                default:
                    Console.WriteLine("what?");
                    break;
            }
        }
    }
}
