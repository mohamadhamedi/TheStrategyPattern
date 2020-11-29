using System;
using System.Collections.Generic;
using System.Text;
using TheStrategyPattern.Enum;

namespace TheStrategyPattern
{
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        private readonly ILogger logger;

        public CreditCardPaymentStrategy(ILogger logger)
        {
            this.logger = logger;
        }
        public void ProcessPayment()
        {
            logger.LogPaymentType(Enums.PaymentType.CredeitCard);
        }
    }
}
