using System.Collections.Generic;
using System.Linq;
using MessageBroker;

namespace SampleConsoleApp
{
    internal class Service2 : ISubscriber, IService
    {
        private Queue<IMessage> _messages = new Queue<IMessage>();


        public void HandleMessage(IMessage message)
        {
            _messages.Enqueue(message);
        }


        public IEnumerable<IMessage> GetQueuedMessages()
        {
            return _messages.AsEnumerable();
        }
    }
}