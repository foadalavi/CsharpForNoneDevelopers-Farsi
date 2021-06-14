using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_24
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            //Console.WriteLine(p.GetType());
            //Console.WriteLine(typeof(Person));

            //p.Name = "Foad";
            //Console.WriteLine(p.GetName());

            var t = typeof(Person);
            var instance = Activator.CreateInstance(t);

            var propInfo = t.GetProperty("Name");
            propInfo.SetValue(instance, "Ali");

            var methodGetNameInfo = t.GetMethod("GetName");
            var name = methodGetNameInfo.Invoke(instance, null);

            Console.WriteLine(name);

            var methodSetNameInfo = t.GetMethod("SetName");
            methodSetNameInfo.Invoke(instance, new object[] { "Hesam" });

            name = methodGetNameInfo.Invoke(instance, null);

            Console.WriteLine(name);

            var fldYearofBirthInfo = t.GetField("_yearOfBirth", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            fldYearofBirthInfo.SetValue(instance, 1980);

            var methodGetAgeInfo = t.GetMethod("GetAge", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var age = methodGetAgeInfo.Invoke(instance, null);

            Console.WriteLine(age);

            Console.ReadKey();
        }
    }
}
