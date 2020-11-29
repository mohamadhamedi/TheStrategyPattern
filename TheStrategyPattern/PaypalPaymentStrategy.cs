using System;
using System.Collections.Generic;
using System.Text;
using TheStrategyPattern.Enum;

namespace TheStrategyPattern
{
    public class PaypalPaymentStrategy : IPaymentStrategy
    {
        private readonly ILogger logger;

        public PaypalPaymentStrategy(ILogger logger)
        {
            this.logger = logger;
        }
        public void ProcessPayment()
        {
            logger.LogPaymentType(Enums.PaymentType.PayPal);
        }
    }
}
