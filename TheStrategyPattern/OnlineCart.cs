using System;
using System.Collections.Generic;
using System.Text;
using static TheStrategyPattern.Enum.Enums;

namespace TheStrategyPattern
{
    public class OnlineCart
    {
        public void Checkout(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.CredeitCard:
                    ProcessCreditCardPayment();
                    break;
                case PaymentType.AmazonPayments:
                    ProcessAmazonPayment();
                    break;
                case PaymentType.GoogleCheckout:
                    ProcessGooglePayment();
                    break;
                case PaymentType.PayPal:
                    ProcessPayPalPeyment();
                    break;
            }
        }

        private void ProcessPayPalPeyment()
        {
            Console.WriteLine("PayPal Card payment chosen");
        }

        private void ProcessGooglePayment()
        {
            Console.WriteLine("Google payment chosen");
        }

        private void ProcessAmazonPayment()
        {
            Console.WriteLine("Amazon payment chosen");
        }

        private void ProcessCreditCardPayment()
        {
            Console.WriteLine("Credit card payment chosen");
        }
    }
}
