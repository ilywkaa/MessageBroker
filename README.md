# MessageBroker
Here is a sample project of message broker.

Inside the library we have Broker class with methods:
void Post(IMessage message);
void Subscribe(ISubscriber Subscriber);
void Unsubscribe(ISubscriber Subscriber);

Also ISubscriber and IMessage interfaces added.

In simple ConsoleApp you can have a look how to use broker, services and messagging collectively.
