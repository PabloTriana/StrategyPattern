using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.SwimBehavior
{
    public class SwimWithBoat : ISwimBehavior
    {
        public void swim()
        {
            Console.WriteLine("I'm Swim in a Boat!");
        }
    }
}
