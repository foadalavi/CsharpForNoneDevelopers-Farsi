using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_25
{
    public class Animal
    {
        public string Name { get; set; }
        public AnimalType Type { get; set; }

        public override string ToString()
        {
            return $"{GetTypeValue(Type)} - {Name}";
        }

        private string GetTypeValue(AnimalType type)
        {
            var value = "";
            switch (type)
            {
                case AnimalType.Cat:
                    value = "Cat";
                    break;
                case AnimalType.Dog:
                    value = "Dog";
                    break;
                default:
                    value = "Undefined";
                    break;
            }

            return value;
        }
    }
}
