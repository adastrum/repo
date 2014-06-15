namespace gonzo.Patterns.Builder
{
    class Director
    {
        private Builder _builder;

        public Director(Builder builder)
        {
            _builder = builder;
        }
    }
}
