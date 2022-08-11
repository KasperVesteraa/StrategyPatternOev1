using System;

namespace StrategyPatternOev1
{
    public class SimpleFlyBehaviour : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("This is simple flying!");
        }
    }
}