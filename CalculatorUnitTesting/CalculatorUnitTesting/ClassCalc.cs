using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnitTesting
{
    public class ClassCalc
    {
        public int resPlus = 0;
        public int resMinus = 0;
        public int resGange = 0;
        public double resDivider = 0D;
        public void BeregnAlt(int tal1, int tal2)
        {
            

            resPlus = tal1 + tal2;
            resMinus = tal1 - tal2;
            resGange = tal1 * tal2;
            resDivider = Convert.ToDouble(tal1) / Convert.ToDouble(tal2);

        }
    }
}
