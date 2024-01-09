using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class udvariasember : ember
    {
        public udvariasember(string vnev, string knev) : base(vnev, knev)
        {
            
        }
        public void koszon()
        {
            Console.WriteLine("szia uram!");
        }
        public void koszonnevvel()
        {
            Console.WriteLine("szia uram! {0} vagyok!", teljesnev);
        }
        public void koszon(ember e)
        {
            Console.WriteLine("szia {0}uram!", e.teljesnev);
        }
        public void koszonnevvel(ember e)
        {
            Console.WriteLine("szia {1} uram! {0} vagyok!", teljesnev, e.teljesnev);
        }
    }
}
