using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Models
{
    public abstract class PaymentBase
    {
        public virtual bool Pay(decimal amount) { return true; }
        //public virtual void Refund(decimal amount)
        //{
        //    throw new NotImplementedException("Refund no está soportado, a veces sí, a veces no.");
        //}
    }
}
