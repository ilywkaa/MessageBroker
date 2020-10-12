using System;
using System.Collections.Generic;

namespace MessageBroker
{
    public class Broker
    {
        private readonly List<ISubscriber> _subscribers = new List<ISubscriber>();
            

        public void Post(IMessage message)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));

            if (_subscribers.Count > 0)
            {
                foreach (var subscriber in _subscribers)
                {
                    subscriber.HandleMessage(message);
                }
            }
        }


        public void Subscribe(ISubscriber subscriber)
        {
            if (subscriber == null) throw new ArgumentNullException(nameof(subscriber));

            if (!_subscribers.Contains(subscriber))
            {
                _subscribers.Add(subscriber);
            }
        }


        public void Unsubscribe(ISubscriber subscriber)
        {
            if (subscriber == null) throw new ArgumentNullException(nameof(subscriber));
            _subscribers.Remove(subscriber);
        }
    }
}
