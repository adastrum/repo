namespace gonzo.Patterns.Mediator
{
    abstract class Mediator
    {
        protected abstract void CreateColleagues();

        public abstract void ColleagueChanged(Colleague colleague);
    }

    class ConcreteMediator : Mediator
    {
        protected override void CreateColleagues()
        {
        }

        public override void ColleagueChanged(Colleague colleague)
        {
        }
    }
}
