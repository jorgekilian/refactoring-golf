using System;

namespace Hole5 {
    public class TaxRate {
        private readonly double percent;

        public TaxRate(int percent) {
            this.percent = percent;
        }

        public Money Apply(Money first, Money total) {
            Double amount = total.value * (percent / 100d);
            return Money.Create(Convert.ToInt32(amount), first.currency);
        }

        public static TaxRate Of(int percent) {
            return new TaxRate(percent);
        }
    }
}