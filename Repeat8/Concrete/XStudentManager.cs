using Repeat8.Abstract;

namespace Repeat8.Concrete
{
    internal class XStudentManager(ICheckStudentManager checkStudentManager) : BaseStudentManager
    {
        private readonly ICheckStudentManager _checkStudentManager = checkStudentManager;
        //Yuxaridaki emeliyyata dependies injection deyilir
        public override void Add(Student student)
        {
         if( _checkStudentManager.CheckStudent((short) (DateTime.Now.Year- student.Birthday.Year)))
            base.Add(student);
            else
            {
                throw new Exception("Yash heddiniz uygun deyil");
            }

        }
    }
}
