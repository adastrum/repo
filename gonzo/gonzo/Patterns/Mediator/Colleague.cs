namespace gonzo.Patterns.Mediator
{
    class Colleague
    {
        private Mediator _mediator;

        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void NotifyMediator()
        {
            _mediator.ColleagueChanged(this);
        }
    }
}
