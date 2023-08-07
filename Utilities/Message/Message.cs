﻿using MailKit.Net.Smtp;
using MimeKit;
using System.Collections.Generic;
using System.Linq;


namespace Fiorella_second.Utilities.Message
{
    public class Message
    {
        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public Message(IEnumerable<string> to, string subject, string content)
        {
            To = new List<MailboxAddress>();
            //To.AddRange(to.Select(x => new MailboxAddress(x)));
            Subject = subject;
            Content = content;
        }
    }
}
