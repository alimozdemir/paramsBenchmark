namespace paramsBenchmark
{
    public class FooParams
    {
        public static int Count;
        public static void Bar(params object[] args)
        {
            Count++;
        }
    }
}