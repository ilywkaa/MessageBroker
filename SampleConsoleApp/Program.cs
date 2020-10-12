using System;
using System.Collections;
using System.Collections.Generic;
using MessageBroker;

namespace SampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //set up
            var broker = new Broker();
            var service1 = new Service1();
            var service2 = new Service2();
            var service3 = new Service3();

            var message1 = new CustomMessage("!message 1!");
            broker.Subscribe(service1);
            broker.Post(message1);

            Console.WriteLine("1st service added.");
            PrintMessages(service1, nameof(service1));

            var message2 = new CustomMessage("!message 2!");
            broker.Subscribe(service2);
            broker.Post(message2);

            Console.WriteLine();
            Console.WriteLine("2nd service added.");
            PrintMessages(service1, nameof(service1));
            PrintMessages(service2, nameof(service2));
            
            var message3 = new CustomMessage("!message 3!");
            broker.Unsubscribe(service1);
            broker.Subscribe(service3);
            broker.Post(message3);

            Console.WriteLine();
            Console.WriteLine("3rd service added.");
            PrintMessages(service1, nameof(service1));
            PrintMessages(service2, nameof(service2));
            PrintMessages(service3, nameof(service3));
        }

        private static void PrintMessages(IService service, string name)
        {
            IEnumerable<IMessage> serviceMessages = service.GetQueuedMessages();
            foreach (var message in serviceMessages)
            {
                Console.WriteLine($"{name} has has message: {message.GetTextMessage()}");
            }
        }
    }
}
