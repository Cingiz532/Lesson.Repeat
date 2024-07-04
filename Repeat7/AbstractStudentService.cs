using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat7
{
    internal abstract class AbstractStudentService
    {
        public abstract void Add();
        public abstract void Update();
        public abstract void Delete();
        public void TestUser()
        {
            Console.WriteLine("User yoxlanildi");
        }
    }
}
