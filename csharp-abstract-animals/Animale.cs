using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animale
    {   
        public virtual string Name { get; set; }
        public void Dormi()
        {
            Console.WriteLine("Zzzzz");
        }

        public abstract void Verso();

        public abstract void CosaMangi();
    }
}
