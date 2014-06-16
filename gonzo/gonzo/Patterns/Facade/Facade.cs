namespace gonzo.Patterns.Facade
{
    class Facade
    {
        public ISerializer<Data> Serializer;
        public IMailService MailSender;
        public IMailParser MailParser;
    }

    class Data { }

    class Message { }

    interface ISerializer<T>
    {
        void Serialize(T o);
        T Deserialize();
    }

    interface IMailService
    {
        void Send(Message message);
        Message Receive();
    }

    interface IMailParser
    {
        Data Parse(Message message);
    }
}
