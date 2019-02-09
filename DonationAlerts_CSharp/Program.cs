using System;

namespace DonationAlerts_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DonationAlerts donationAlerts = new DonationAlerts("YOUR SECRET TOKEN!");
            donationAlerts.Connect();

            donationAlerts.OnDonation += ShowDonation;

            Console.ReadLine();
        }

        private static void ShowDonation(object data)
        {
            Console.WriteLine(data.ToString());
        }
    }
}
