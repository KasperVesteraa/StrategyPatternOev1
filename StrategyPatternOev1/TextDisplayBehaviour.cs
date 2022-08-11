using System;

namespace StrategyPatternOev1
{
    public class TextDisplayBehaviour : IDisplayBehaviour
    {
        public void Display()
        {
            Console.WriteLine("I display as text!");
        }
    }
}