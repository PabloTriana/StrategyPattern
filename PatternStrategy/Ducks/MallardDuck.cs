using PatternStrategy.FlyBehavior;
using PatternStrategy.QuackBehavior;
using PatternStrategy.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            /*
            base.flyBehavior = new FlyNoWay();
            base.quackBehavior = new MuteQuack();
            base.swimBehavior = new SwimNoWay();
            */
            
        }
        public override void display()
        {
            Console.WriteLine("Mallard Duck");
        }


    }
}
