﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale
    {
        public override string Name { get; set; } = "Passerotto";
        public override void CosaMangi()
        {
            Console.WriteLine("Lombrichi");
        }

        public override void Verso()
        {
            Console.WriteLine("Cip cip!");
        }
    }
}
