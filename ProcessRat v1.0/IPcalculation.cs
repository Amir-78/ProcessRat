using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessRat_v1._0
{
    class IPcalculation
    {

        public static string getIP(uint myDecimal)
        {

            var One = myDecimal % 256;
            var Two = myDecimal / 256 % 256;
            var Three = myDecimal / 256 / 256 % 256;
            var Four = myDecimal / 256 / 256 / 256;

            return One + "." + Two + "." + Three + "." + Four;
    }
    }
}
