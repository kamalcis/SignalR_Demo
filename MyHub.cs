using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR_Demo
{
    public class MyHub : Hub
    {

        public static string UserName { get; set; }

        public void Connect(string user)
        {
            UserName = user;
        }

        public void SayHello(string message)
        {
            string result = UserName + ";" + message;
            Clients.All.receiveNotification(result);
        }
    }
}