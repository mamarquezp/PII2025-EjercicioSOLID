using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PII2025_EjercicioSOLID.Models;

namespace PII2025_EjercicioSOLID.SOLID_Services
{
    internal class TransferPayment : PaymentBase
    {
        public override bool Pay(decimal amount)
        {
            Console.WriteLine($"[TRANSFER] Enviada orden al banco por {amount:C}");
            return true;
        }
    }
}
