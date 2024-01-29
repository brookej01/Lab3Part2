using Lab3Part2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part2
{
    public class DogPart2 : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        public string Cry()
        {
            return "Woof!";
        }
    }
}
