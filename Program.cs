using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Строка1";
            string str2 = new string('s', 5);
            char[] charray = { 't', 'e', 's', 't' };
            string str3 = new string(charray);

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
        }
    }
}
