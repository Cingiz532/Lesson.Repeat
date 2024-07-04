using Repeat9.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat9.Abstract
{
    internal abstract class BaseCompanyManager : IBaseManager<Worker>
    {
        public  virtual void Add(Worker worker)
        {
            Console.WriteLine($" Xos gelmisiniz . Sirketimize  {worker.Name} adli  isci elave olundu :)");
        }

        public void Delete(Worker worker)
        {
            throw new NotImplementedException();
        }

        public void Update(Worker worker)
        {
            throw new NotImplementedException();
        }
    }
}
