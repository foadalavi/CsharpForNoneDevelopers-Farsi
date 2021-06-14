using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_25
{
    public static class ext
    {
        public static string AddDotToEnd(this string item)
        {
            return item + ".";
        }
        public static string AddSomethingToEnd(this string item, string something)
        {
            return item + something;
        }

        public static T To<T>(this object value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}
