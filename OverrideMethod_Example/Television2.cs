using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethod_Example
{
    public  class Television2:Television
    {
        public override void TelevisionFixedRates( double Sony, double LG, double Samsung)
        {
           // base.TelevisionFixedRates();
            Console.WriteLine(" The diwali offer of television cost");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("The cost of Sony is : " + Sony);
            Console.WriteLine("The cost of LG TV  is : " + LG);
            Console.WriteLine("The cost of Sumsung TV is : " + Samsung);
            Console.ReadLine();
        }

    }
}
