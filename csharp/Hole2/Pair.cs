namespace Hole2
{
    public class Money<A, B>
    {
        public readonly A value;
        public readonly B second;

        public Money(A value, B second)
        {
            this.value = value;
            this.second = second;
        }
    }
}