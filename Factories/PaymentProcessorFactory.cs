using PII2025_EjercicioSOLID.Interfaces;
using PII2025_EjercicioSOLID.SOLID_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Factories

{
    public class PaymentProcessorFactory
    {
        private readonly Dictionary<string, IPaymentProcessor> processors = new();

        public PaymentProcessorFactory()
        {
            processors["card"] = new CardPayment();
            processors["cash"] = new CashPayment();
            processors["transfer"] = new TransferPayment();
            processors["crypto"] = new CryptoPayment();
        }

        public IPaymentProcessor GetProcessor(string paymentType)
        {
            // Si el tipo de pago no se encuentra, devuelve efectivo por defecto.
            return processors.ContainsKey(paymentType) ? processors[paymentType] : processors["cash"];
        }
    }
}
