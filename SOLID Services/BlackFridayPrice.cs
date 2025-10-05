using PII2025_EjercicioSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Class
{
    internal class BlackFridayPrice : IPriceDiscount
    {
        public override decimal CalculatePrice(decimal basePrice)
        {
            var finalPrice = basePrice * 0.7m;
            return finalPrice;
        }
        
    }
}
