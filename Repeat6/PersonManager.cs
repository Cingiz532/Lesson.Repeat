using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat6
{
    internal class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine($"{person.FullName} siyahiya elave olundu");
        }
    }
}
