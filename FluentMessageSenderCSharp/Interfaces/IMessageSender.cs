using System;

namespace FluentMessageSenderCSharp.Interfaces
{
    public interface IMessageSender
    {
        void SendMessage(string text, string sender, string receiver);
    }
}