using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Cane : Animale
    {
        public override string Name { get; set; } = "Cane";
        public override void CosaMangi()
        {
            Console.WriteLine("Croccantini");
        }

        public override void Verso()
        {
            Console.WriteLine("Bau bau!");
        }
    }
}
