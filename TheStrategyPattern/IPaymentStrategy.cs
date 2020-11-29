using System;
using System.Collections.Generic;
using System.Text;
using static TheStrategyPattern.Enum.Enums;

namespace TheStrategyPattern
{
    public interface IPaymentStrategy
    {
        void ProcessPayment();
    }
}
