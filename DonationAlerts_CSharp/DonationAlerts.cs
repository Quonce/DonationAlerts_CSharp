using Quobject.SocketIoClientDotNet.Client;
using System;

namespace DonationAlerts_CSharp
{
    class DonationAlerts
    {
        public Action<object> OnDonation;

        private string uri = "http://socket.donationalerts.ru";
        private int port = 3001;
        string secretToken = "";
        
        public DonationAlerts(string secretToken)
        {
            this.secretToken = secretToken;
        }

        public void Connect()
        {
            var socket = IO.Socket(uri, new IO.Options() { Port = port });

            socket.Emit("add-user", new string[] { secretToken, "minor" });
            socket.On("add-user", OnDonation);
        }
        
    }
}
