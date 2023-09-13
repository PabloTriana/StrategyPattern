using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.FlyBehavior
{
    public class FlyWithRocket : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm Flying With Rocket!");
        }
    }
}
