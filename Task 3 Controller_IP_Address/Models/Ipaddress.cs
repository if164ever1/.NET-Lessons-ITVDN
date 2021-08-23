using System;
using System.Net;

namespace Task_3_Controller_IP_Address.Models
{
    public class Ipaddress
    {
        public string IP { get; }
        public string hostName { get; }

        public Ipaddress()
        {
            hostName = Dns.GetHostName();
            IP = Dns.GetHostByName(hostName).AddressList[1].ToString();
        }
    }
}
