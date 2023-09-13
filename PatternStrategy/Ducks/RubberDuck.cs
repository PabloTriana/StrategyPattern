using PatternStrategy.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            
        }
        public override void display()
        {
            Console.WriteLine("Rubber Duck");
        }
    }
}
