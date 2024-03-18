using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritence_manjulaRajan
{
    internal class Helicopter :Air
    {

       public int _numberOfPropellers;

        public Helicopter(int numberOfPropellers)
        {
            _numberOfPropellers = numberOfPropellers;


        }

        public Helicopter(string color, int numberOfPropellers): base(color)
        {

            numberOfPropellers = 2;
        }


        public override string ToString()
        {
            return $"{base.ToString()} - Numer of Propeller {_numberOfPropellers}";
        }


    }
}
