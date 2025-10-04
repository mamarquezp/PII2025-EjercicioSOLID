using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PII2025_EjercicioSOLID.Models;

namespace PII2025_EjercicioSOLID.SOLID_Services
{
    internal class CashPayment : PaymentBase
    {
        public override bool Pay(decimal amount)
        {
            Console.WriteLine($"[CASH] Registrado {amount:C}");
            return true;
        }
        public override void Refund(decimal amount)
        {
            Console.WriteLine($"[CASH] Refund {amount:C}");
        }
    }
}
