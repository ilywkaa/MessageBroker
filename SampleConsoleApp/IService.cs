using System.Collections.Generic;
using MessageBroker;

namespace SampleConsoleApp
{
    public interface IService
    {
        IEnumerable<IMessage> GetQueuedMessages();
    }
}