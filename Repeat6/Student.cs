using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat6
{
    internal class Student : Person
    {
        public int Id { get; set; }
        public double Point { get; set; }
    

    public void AgeControl(short age)
    {
        if(age>=18)
            {
                Age = age;
            }
    }
    }
}
