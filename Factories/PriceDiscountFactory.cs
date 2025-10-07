using PII2025_EjercicioSOLID.Class;
using PII2025_EjercicioSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Factories
{
    public class PricingStrategyFactory
    {
        private readonly Dictionary<string, IPriceDiscount> strategies = new();

        public PricingStrategyFactory()
        {
            strategies["blackfriday"] = new BlackFridayPrice();
            strategies["vip"] = new VipPrice();
            strategies["alumni"] = new AlumniPrice();
            strategies["standard"] = new StandarPrice();
        }

        public IPriceDiscount GetStrategy(string promoCode)
        {
            return strategies.ContainsKey(promoCode) ? strategies[promoCode] : strategies["standard"];
        }
    }
}
