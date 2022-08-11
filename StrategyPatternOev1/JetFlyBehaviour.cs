using System;

namespace StrategyPatternOev1
{
    public class JetFlyBehaviour : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("This is jet flying!");
        }
    }
}