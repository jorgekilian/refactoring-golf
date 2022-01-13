using System;

namespace Hole2
{
    public class Money
    {
        public readonly int value;
        public readonly String currency;

        public Money(int first, String currency)
        {
            this.value = first;
            this.currency = currency;
        }
    }
}