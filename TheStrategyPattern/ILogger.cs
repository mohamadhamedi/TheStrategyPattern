using System;
using System.Collections.Generic;
using System.Text;
using static TheStrategyPattern.Enum.Enums;

namespace TheStrategyPattern
{
    public interface ILogger
    {
        public void LogPaymentType(PaymentType paymentType);
    }
}
