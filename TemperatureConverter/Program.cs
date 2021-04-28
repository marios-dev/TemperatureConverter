using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the convertor direction");
            Console.WriteLine("1. From Celsius to Fahreneit");
            Console.WriteLine("2. From Fahreneit to Celsius");
            Console.Write(":");
            string selection = Console.ReadLine();
            double F, C = 0;
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Please enter the Celcius temperature: ");
                    F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                    break;
                case "2":
                    Console.WriteLine("Please enter the Fahrenheit temperature: ");
                    C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                    Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                    break;
                default:
                    Console.WriteLine("Please select a convertor.");
                    break;
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
