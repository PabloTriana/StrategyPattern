using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.SwimBehavior
{
    public class SwimNoWay : ISwimBehavior
    {
        public void swim()
        {
            Console.WriteLine("I'm not swimming!");
        }
    }
}
