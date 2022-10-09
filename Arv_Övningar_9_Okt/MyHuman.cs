using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Övningar_9_Okt
{
    public class MyHuman : IFamilyName, INameable
    {
        public string Name { get; set; } = "";
        public string LastName { get; set; } = "";
    }
}
