using System;

namespace StrategyPatternOev1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Duck duck1 = new Duck(new SimpleFlyBehaviour(), new SimpleQuackBehaviour(), new TextDisplayBehaviour());
            Duck duck2 = new Duck(new JetFlyBehaviour(), new NoQuackBehaviour(), new TextDisplayBehaviour());
            Duck duck3 = new Duck(new SimpleFlyBehaviour(), new NoQuackBehaviour(), new GraphicDisplayBehaviour());

            Console.WriteLine("Duck1:");
            duck1.Fly();
            duck1.Quack();
            duck1.Display();

            Console.WriteLine("Duck2:");
            duck2.Fly();    
            duck2.Quack();
            duck2.Display();
            
            Console.WriteLine("Duck3:");
            duck3.Fly();
            duck3.Quack();
            duck3.Display();
        }
    }
}