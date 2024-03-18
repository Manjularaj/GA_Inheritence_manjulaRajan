﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritence_manjulaRajan
{
    internal class Plane : Air
    {
        public int _numberOfJets;

        public Plane(int numberOfJets)
        {
            _numberOfJets = numberOfJets;
        }

        public Plane(string color, int numberOfJets) : base(color)
        {
            numberOfJets = 3;

        }

        public int NumberOfJets { get => _numberOfJets; set => _numberOfJets = value; }

        public override string ToString()
        {
            return $"{base.ToString()} - Number of Jets {NumberOfJets}";



        }


    }
}
