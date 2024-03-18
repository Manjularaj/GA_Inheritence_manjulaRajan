using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritence_manjulaRajan
{
    public class Air :Vehicle
    {
        public Air() : base("uu")
        {


        }

        public Air(string color) : base(color)
        {
        }

        public enum SeaType
        {
            Boat,
            Submarine

        }

    }
}
