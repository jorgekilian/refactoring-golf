namespace Hole2
{
    public class Money<A, B>
    {
        public readonly int value;
        public readonly string currency;

        public Money(int value, string currency)
        {
            this.value = value;
            this.currency = currency;
        }
    }
}