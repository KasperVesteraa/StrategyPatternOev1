using System;

namespace StrategyPatternOev1
{
    public class NoQuackBehaviour : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("This is a no-quack!");
        }
    }
}