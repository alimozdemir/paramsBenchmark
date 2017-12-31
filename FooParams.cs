namespace paramsBenchmark
{
    public class FooParams
    {
        public static int BarObjectCount, BarIntegerCount;
        public static void BarObject(params object[] args)
        {
            BarObjectCount++;
        }

        public static void BarInteger(params int[] args)
        {
            BarIntegerCount++;
        }
        
    }
}