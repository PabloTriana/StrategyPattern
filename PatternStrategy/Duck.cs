using PatternStrategy.FlyBehavior;
using PatternStrategy.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.QuackBehavior
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;
        public ISwimBehavior swimBehavior;

        public Duck() {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
            swimBehavior = new SwimDuck();
            
        }

        public abstract void display();

        public void perfomFly()
        {
            flyBehavior.fly();
        }

        public void perfomQuack()
        {
             quackBehavior.quack();
        }

        public void swim()
        {
            swimBehavior.swim();    
        }

    }
}
