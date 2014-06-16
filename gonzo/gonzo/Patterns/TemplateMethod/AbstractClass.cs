namespace gonzo.Patterns.TemplateMethod
{
    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            PrimitiveOperation();
        }

        public abstract void PrimitiveOperation();
    }

    class ConcreteClass : AbstractClass
    {
        public override void PrimitiveOperation()
        {

        }
    }
}
