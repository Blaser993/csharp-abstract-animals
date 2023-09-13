using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale
    {
        public override string Name { get; set; } = "Aquila";


        public override void CosaMangi()
        {
            Console.WriteLine("Passerotti");
        }

        public override void Verso()
        {
            Console.WriteLine("Aaaaah... ahh!");
        }
    }
}
