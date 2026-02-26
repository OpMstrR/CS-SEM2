using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class Noti
    {
        public delegate void NotificationHandler(string message);

        internal static void SendEmail(string msg)
        {
            Console.WriteLine($"Email sent {msg}");
        }

        internal static void SendSMS(string msg)
        {
            Console.WriteLine($"SMS sent {msg}");

        }

        internal static void Sent(string msg2)
        {
            NotificationHandler notify = SendEmail;


            notify(msg2);
        }

    }
}
