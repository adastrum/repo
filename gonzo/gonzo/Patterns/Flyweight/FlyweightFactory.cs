namespace gonzo.Patterns.Flyweight
{
    class FlyweightFactory
    {
        public Flyweight Create()
        {
            return new ConcreteFlyweight();
        }
    }
}
