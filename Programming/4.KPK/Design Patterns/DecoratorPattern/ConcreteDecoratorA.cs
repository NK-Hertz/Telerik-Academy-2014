using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // "ConcreteDecoratorA" 
    class ConcreteDecoratorA : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}
