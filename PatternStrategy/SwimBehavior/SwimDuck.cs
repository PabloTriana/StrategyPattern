using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.SwimBehavior
{
    public class SwimDuck : ISwimBehavior
    {
        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
