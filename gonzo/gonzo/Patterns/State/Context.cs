namespace gonzo.Patterns.State
{
    class Context
    {
        private State _state;

        public void Request()
        {
            _state.Handle();
        }
    }
}
