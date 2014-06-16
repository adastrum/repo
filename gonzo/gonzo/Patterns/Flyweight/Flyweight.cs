namespace gonzo.Patterns.Flyweight
{
    abstract class Flyweight
    {
        public abstract void Operation();
    }

    class ConcreteFlyweight : Flyweight
    {
        public override void Operation()
        {
        }
    }
}
