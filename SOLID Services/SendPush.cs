using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PII2025_EjercicioSOLID.Interfaces;

namespace PII2025_EjercicioSOLID.SOLID_Services
{
    internal class SendPush : INotifierFat
    {
        public override void SendNotification(string deviceId, string message, string x)
            => throw new NotSupportedException("Push no está disponible en consola, pero la interfaz lo exige.");

    }
}
