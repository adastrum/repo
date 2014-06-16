namespace gonzo.Patterns.ChainOfResponsibility
{
    class Handler
    {
        private Handler _successor;

        public void HandleHelp()
        {
            if (_successor != null)
            {
                _successor.HandleHelp();
            }
        }
    }
}
