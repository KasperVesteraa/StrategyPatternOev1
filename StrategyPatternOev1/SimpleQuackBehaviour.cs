using System;

namespace StrategyPatternOev1
{
    class SimpleQuackBehaviour : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("This is a simple quack!");
        }
    }
}