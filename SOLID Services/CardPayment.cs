using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PII2025_EjercicioSOLID.Models;

namespace PII2025_EjercicioSOLID.SOLID_Services
{
    internal class CardPayment: PaymentBase
    {
        public override bool Pay(decimal amount)
        {
            Console.WriteLine($"[CARD] Cobrado {amount:C}");
            return true;
        }
    }
}
