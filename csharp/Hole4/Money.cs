using System;

namespace Hole4
{
    public class Money
    {
        public readonly int value;
        public readonly String currency;

        private Money(int value, String currency)
        {
            this.value = value;
            this.currency = currency;
        }

        public static Money Create(int value, String currency) {
            return new Money(value, currency);
        }

        public Money Plus(Money other)
        {
            if (!other.currency.Equals(currency))
            {
                throw new Incalculable();
            }

            return new Money(value + other.value, other.currency);
        }
    }
}