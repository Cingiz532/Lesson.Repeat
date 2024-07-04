using Repeat9.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat9.Concrete
{
    internal class BCompanyManager : BaseCompanyManager
    {
        public override void Add(Worker worker)
        {
            if ((DateTime.Now.Year - worker.Birthday.Year) >= 22)
            {
                base.Add(worker);
            }
            else
            {
                throw new Exception("Sizin yash heddiniz sirketimize uygun deyil :(");
            }
        }
    }
}
