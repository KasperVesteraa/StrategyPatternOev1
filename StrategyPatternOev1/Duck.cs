namespace StrategyPatternOev1
{
    public class Duck
    {
        private IFlyBehaviour _flyBehaviour;
        private IQuackBehaviour _quackBehaviour;
        private IDisplayBehaviour _displayBehaviour;

        public Duck(IFlyBehaviour fb, IQuackBehaviour qb, IDisplayBehaviour db)
        {
            this._flyBehaviour = fb;
            this._quackBehaviour = qb;
            this._displayBehaviour = db;
        }

        public void Fly()
        {
            this._flyBehaviour.Fly();
        }

        public void Quack()
        {
            this._quackBehaviour.Quack();
        }

        public void Display()
        {
            this._displayBehaviour.Display();
        }
    }
}