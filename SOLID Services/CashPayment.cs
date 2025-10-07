using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PII2025_EjercicioSOLID.Interfaces;
using PII2025_EjercicioSOLID.Models;

namespace PII2025_EjercicioSOLID.SOLID_Services
{
    internal class CashPayment : IPaymentProcessor
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Pagando en efectivo {amount:C}");
            return true;
        }
        //public override void Refund(decimal amount)
        //{
        //    Console.WriteLine($"Devolviendo {amount:C}");
        //}
    }
}
