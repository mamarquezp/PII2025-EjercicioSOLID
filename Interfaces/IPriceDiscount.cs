using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Interfaces
{
    internal abstract class IPriceDiscount
    {
        public abstract decimal CalculatePrice(decimal basePrice);
    }
}
