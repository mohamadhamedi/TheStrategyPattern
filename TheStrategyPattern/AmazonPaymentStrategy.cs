using System;
using System.Collections.Generic;
using System.Text;
using TheStrategyPattern.Enum;

namespace TheStrategyPattern
{
    public class AmazonPaymentStrategy : IPaymentStrategy
    {
        private readonly ILogger logger;

        public AmazonPaymentStrategy(ILogger logger)
        {
            this.logger = logger;
        }
        public void ProcessPayment()
        {
            logger.LogPaymentType(Enums.PaymentType.AmazonPayments);
        }
    }
}
