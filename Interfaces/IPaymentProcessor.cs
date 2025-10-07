using PII2025_EjercicioSOLID.SOLID_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Interfaces
{
    public interface IPaymentProcessor
    {
        bool Payment(decimal amount);
    }
}
