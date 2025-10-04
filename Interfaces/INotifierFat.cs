using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Interfaces
{
    internal abstract class INotifierFat
    {
        public abstract void SendNotification(string to, string subject, string message);
    }
}
