using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public Car()
        {

        }

        public string Make {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void PrintTheGoods()
        {
            Console.WriteLine($"The vehicle is a {Make} {Model}, from the divine year of {Year}.");
        }
    }
}
