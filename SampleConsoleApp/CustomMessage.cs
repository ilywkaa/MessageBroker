using MessageBroker;

namespace SampleConsoleApp
{
    internal class CustomMessage : IMessage
    {
        private string _messageText;


        public CustomMessage(string text)
        {
            _messageText = text;
        }


        public string GetTextMessage() => _messageText;
    }
}