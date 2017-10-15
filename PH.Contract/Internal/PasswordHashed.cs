using System;
using System.Net;

namespace PH.Contract.Internal
{
    public class PasswordHashed
    {
        public string HashMethod { get; set; }
        public string PlainText { get; set; }
        public IPAddress IpAddress { get; set; }
        public DateTime HashRequestTimeUtc { get; set; }
    }
}
