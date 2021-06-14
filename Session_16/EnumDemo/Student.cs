using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Student
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public EducationGrad Grad { get; set; } // 1=Ps , 2=ms , 3=hs , 4=u
    }
}
