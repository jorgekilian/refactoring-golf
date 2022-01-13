﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Hole4
{
    public class TakeHomeCalculator
    {
        private readonly int percent;

        public TakeHomeCalculator(int percent)
        {
            this.percent = percent;
        }

        public Money NetAmount(Money first, params Money[] rest) {
            List<Money> monies = rest.ToList();

            Money total = first;

            foreach (Money next in monies) {
                total = total.Plus(next);
            }

            Double amount = total.value * (percent / 100d);
            Money tax = new Money(Convert.ToInt32(amount), first.currency);

            return Minus(first, total, tax);

            static Money Minus(Money first, Money total, Money tax) {
                if (!total.currency.Equals(tax.currency)) {
                    throw new Incalculable();
                }

                return new Money(total.value - tax.value, first.currency);
            }
        }
    }
}