using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentMessageSenderCSharp
{
    public class FluentMessager
    {
        public void SendMessage(MessageSender sender)
        {
            sender.SendText("hi").From("Iain").To("Bob");
            sender.SendText("").From("").To("");
            sender.SendText("hi").From(FromAddress.Andrew.ToString()).To("Bob");
        }
    }
}
