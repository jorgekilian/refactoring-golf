namespace Hole2
{
    public class Money<A, B>
    {
        public readonly A value;
        public readonly B currency;

        public Money(A value, B currency)
        {
            this.value = value;
            this.currency = currency;
        }
    }
}