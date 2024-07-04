using Repeat8.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat8.Abstract
{
    internal abstract class BaseStudentManager : IBaseManager<Student>
    {
        public virtual void Add(Student student)
        {
            //-------
            //------
            //yeni metodun uzerine nese yazmaq olur
            Console.WriteLine($" {student.FullName} adli  telebe elave olundu");
        }

        public void Delete(Student student)
        {
            
        }

        public void Update(Student student)
        {
            
        }
    }
}
