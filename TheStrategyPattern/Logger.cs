using System;
using System.Collections.Generic;
using System.Text;
using TheStrategyPattern.Enum;

namespace TheStrategyPattern
{
    public class Logger : ILogger
    {
        public void LogPaymentType(Enums.PaymentType paymentType)
        {
            Console.WriteLine(paymentType.ToString() + " is chosen.");
        }
    }
}
