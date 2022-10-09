using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Övningar_9_Okt
{
    public class Swahili : Greeter
    {
        public override void Hello() => Console.WriteLine("Hujambo");
        public override void Goodbye() => Console.WriteLine("Kwaheri");
    }
}
