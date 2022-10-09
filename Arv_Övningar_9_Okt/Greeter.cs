using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Övningar_9_Okt
{
    public class Greeter
    {
        public virtual void Hello() => Console.WriteLine("Hello");
        public virtual void Goodbye() => Console.WriteLine("Goodbye");
    }
}
