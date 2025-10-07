using PII2025_EjercicioSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Class
{
    internal class StandarPrice : IPriceDiscount
    {
        public decimal CalculatePrice(decimal basePrice)
        {
            var finalPrice = basePrice;
            return finalPrice;
        }
        
    }
}
