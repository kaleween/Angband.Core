﻿using System.Collections.Generic;

namespace Angband.Core
{
    public class Somme
    {
        public Somme(IEnumerable<int> elements)
        {
            Resultat = 0;
            foreach (var element in elements) Resultat += element;
        }

        public long Resultat { get; }
    }
}
