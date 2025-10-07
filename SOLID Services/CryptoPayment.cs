using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PII2025_EjercicioSOLID.Interfaces;
using PII2025_EjercicioSOLID.Models;

namespace PII2025_EjercicioSOLID.SOLID_Services
{
    internal class CryptoPayment : IPaymentProcessor
    {
        public  bool ProcessPayment(decimal amount)
        {
            if (amount != Math.Truncate(amount))
                throw new InvalidOperationException("Crypto solo admite montos enteros");
            Console.WriteLine($"Hash de Crypto ok por {amount:C}");
            return true;
        }
    }
}
