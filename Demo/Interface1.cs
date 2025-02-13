using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //stratgy  Design pattern instead of Delagate
    internal interface IcustomComparer
    {
        public bool Compare(int x, int y);
    }
    class Asce : IcustomComparer
    {
        public bool Compare(int x, int y)
        {
            return x > y;
        }
    }
    class Desc: IcustomComparer
    {
        public bool Compare(int x, int y)
        {
            return x<y;
        }
    }

}
