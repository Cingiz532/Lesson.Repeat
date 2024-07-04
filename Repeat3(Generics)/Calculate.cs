using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat3_Generics_
{
    internal class Calculate
    {
        public void Plus(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public int  Minus(int a, int b)
        {
            return a - b;
        }
        public string SayHello(string Name)
        {
            return Name;//return-den asagi kod oxunmur, return  deadcode sayilir
        }
    }
}
