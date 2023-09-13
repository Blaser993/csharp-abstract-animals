using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale
    {
        public override string Name { get; set; } = "Delfino";
        public override void CosaMangi()
        {
            Console.WriteLine("Pesci");
        }

        public override void Verso()
        {
            Console.WriteLine("Iiihhh! cccrrr... crrrr...");
        }
    }
}
