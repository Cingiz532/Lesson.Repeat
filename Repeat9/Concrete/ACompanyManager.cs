using Repeat9.Abstract;

namespace Repeat9.Concrete
{
    internal class ACompanyManager : BaseCompanyManager
    {
        public override void Add(Worker worker)
        {
            if (worker.Age >= 18)
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
