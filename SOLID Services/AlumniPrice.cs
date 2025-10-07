using PII2025_EjercicioSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.SOLID_Services
{
    internal class AlumniPrice : IPriceDiscount
    {
       public decimal CalculatePrice(decimal basePrice)
        {
            var finalPrice = basePrice* 0.95m;
            return finalPrice;
        }
        
    }
}
