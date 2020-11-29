using System;
using System.Collections.Generic;
using System.Text;
using static TheStrategyPattern.Enum.Enums;

namespace TheStrategyPattern
{
    public class OnlineCart
    {
        public OnlineCart(ILogger logger)
        {
            this.logger = logger;

            paymentStrategies = new Dictionary<PaymentType, IPaymentStrategy>();
            paymentStrategies.Add(PaymentType.CredeitCard, new CreditCardPaymentStrategy(this.logger));
            paymentStrategies.Add(PaymentType.GoogleCheckout, new GooglePaymentStrategy(this.logger));
            paymentStrategies.Add(PaymentType.PayPal, new PaypalPaymentStrategy(this.logger));
            paymentStrategies.Add(PaymentType.AmazonPayments, new AmazonPaymentStrategy(this.logger));
        }
        private IDictionary<PaymentType, IPaymentStrategy> paymentStrategies;
        private readonly ILogger logger;

        public void Checkout(PaymentType paymentType)
        {

            paymentStrategies[paymentType].ProcessPayment();
        }

       
    }
}
