using Repeat8.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat8.Concrete
{
    internal class YStudentManager(ICheckStudentManager checkStudentManager) : BaseStudentManager
    {
       private readonly CheckStudentManager _checkStudentManager1 = new CheckStudentManager();

        public override void Add(Student student)
        {
            if (_checkStudentManager1.CheckStudent((short)(DateTime.Now.Year - student.Birthday.Year)))
            { base.Add(student); }
            else
                throw new Exception("Yash heddiniz uygun deyil");
        }
    }
}
