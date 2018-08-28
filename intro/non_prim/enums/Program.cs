using System;

namespace enums
{
    public enum ShippingMethod
    {
        RegularAirMail      = 1,
        RegisteredAirMail   = 2,
        Express             = 3
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            
            Console.WriteLine(method.ToString()); // Console.WriteLine by default calls ToString(); on anything it prints to console
            
            var methodName = "RegisteredAirMail";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
            
        }
    }
}
