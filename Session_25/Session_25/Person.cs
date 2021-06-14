using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_25
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return $"{this.ID} - {this.Name} {this.Family}";
        }
    }
}
