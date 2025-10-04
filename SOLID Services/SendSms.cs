using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PII2025_EjercicioSOLID.Interfaces;

namespace PII2025_EjercicioSOLID.SOLID_Services
{
    internal class SendSms : INotifierFat
    {
        public override void SendNotification(string phone, string message, string x)
            => Console.WriteLine($"[SMS] To:{phone} Msg:{message}");
    }
}
