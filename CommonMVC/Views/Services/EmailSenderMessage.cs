using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Views.Services
{
    public class EmailSenderMessage : IMessageSender
    {
        public string SendMessage()
        {
            return "The mnessage has been sent to the email";
        }
    }
}
