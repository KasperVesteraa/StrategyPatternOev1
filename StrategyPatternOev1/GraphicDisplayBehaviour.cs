using System;

namespace StrategyPatternOev1
{
    public class GraphicDisplayBehaviour : IDisplayBehaviour
    {
        public void Display()
        {
            Console.WriteLine("I display as graphics!");
        }
    }
}