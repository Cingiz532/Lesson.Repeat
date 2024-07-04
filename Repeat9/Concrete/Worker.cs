using Repeat9.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat9.Concrete
{
    internal class Worker : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Majority { get; set; }
        public short Age { get; set; }
        public DateTime Birthday { get; set; }

    }
}
