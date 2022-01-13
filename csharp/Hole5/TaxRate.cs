using System;

namespace Hole5 {
    public class TaxRate {
        private readonly double percent;

        public Money Apply(Money first, Money total) {
            Double amount = total.value * (percent / 100d);
            return Money.Create(Convert.ToInt32(amount), first.currency);
        }

        public static object Of(int v) {
            throw new NotImplementedException();
        }
    }
}