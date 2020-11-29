using System;
using System.Collections.Generic;
using System.Text;
using TheStrategyPattern.Enum;

namespace TheStrategyPattern
{
    public class GooglePaymentStrategy : IPaymentStrategy
    {
        private readonly ILogger logger;

        public GooglePaymentStrategy(ILogger logger)
        {
            this.logger = logger;
        }
        public void ProcessPayment()
        {
            logger.LogPaymentType(Enums.PaymentType.GoogleCheckout);
        }
    }
}
