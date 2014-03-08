using FluentMessageSenderCSharp.Interfaces;

namespace FluentMessageSenderCSharp
{

    public class MessageSender
    {

        private readonly IMessageSender _messageSender;
        public MessageSender(IMessageSender sender)
        {
            _messageSender = sender;
        }

        public SendExpression SendText(string text)
        {
            return new SendExpression(text, _messageSender);
        }

        public class SendExpression : IToExpression
        {

            private readonly string _text;
            private readonly IMessageSender _messageSender;

            private string _sender;
            public SendExpression(string text, IMessageSender messageSender)
            {
                _text = text;
                _messageSender = messageSender;
            }

            public IToExpression From(string sender)
            {
                _sender = sender;
                return this;
            }

            public void ToExpression(string receiver)
            {
                _messageSender.SendMessage(_text, _sender, receiver);
            }
            void IToExpression.To(string receiver)
            {
                ToExpression(receiver);
            }
        }
    }

 
}