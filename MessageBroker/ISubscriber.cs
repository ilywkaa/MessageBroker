namespace MessageBroker
{
    public interface ISubscriber
    {
        void HandleMessage(IMessage message);
    }
}