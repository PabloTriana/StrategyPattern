using PatternStrategy.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            
        }
        public override void display()
        {
            Console.WriteLine("Model Duck");
        }
    }
}
