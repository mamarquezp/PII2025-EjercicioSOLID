using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PII2025_EjercicioSOLID.Interfaces;
using PII2025_EjercicioSOLID.Models;

namespace PII2025_EjercicioSOLID.SOLID_Services
{
    internal class TransferPayment : IPaymentProcessor
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Transferencia confirmada en banco por {amount:C}");
            return true;
        }
    }
}
