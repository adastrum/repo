namespace gonzo.Patterns.Proxy
{
    abstract class Subject
    {
        public abstract void Request();
    }

    class Proxy : Subject
    {
        private RealSubject _realSubject;

        public override void Request()
        {
            _realSubject.Request();
        }
    }

    class RealSubject : Subject
    {
        public override void Request()
        {
        }
    }
}
