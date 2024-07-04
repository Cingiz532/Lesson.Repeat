using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat3_Generics_
{
    internal class MyGeneric<T>
    {
        T[] number;
        public MyGeneric()
        {
            number = new T[0];
        }
        public void Add(T item)
        {
            T[] temp = number;//evvelki ededi temp de saxlasin(normalda evvelkiler bos idi)
            number =new T[number.Length + 1];//her defe add a tiklayanda 1 vahid artsin

            for(int i = 0; i < number.Length; i++)
            {
                number[i] = temp[i];//tempdeki pulu mene verir
            }
            number[number.Length-1] = item;
            Console.WriteLine(number.Length);
        }
    }
}
