namespace paramsBenchmark
{
    public class FooClassic
    {
        public static int Count;
        public static void Bar1(object arg1)
        {
            Count += 1;
        }
        public static void Bar(object arg1)
        {
            Count += 1;
        }

        public static void Bar(object arg1, object arg2)
        {
            Count += 2;
        }

        public static void Bar(object arg1, object arg2, object arg3)
        {
            Count += 3;
        }

        public static void Bar(object arg1, object arg2, object arg3, object arg4)
        {
            Count += 4;
        }


        public static void Bar(object arg1, object arg2, object arg3, object arg4, object arg5)
        {
            Count += 5;
        }

        public static void Bar(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6)
        {
            Count += 6;
        }

        public static void Bar(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7)
        {
            Count += 7;
        }

        public static void Bar(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8)
        {
            Count += 8;
        }

        public static void Bar(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9)
        {
            Count += 9;
        }

        public static void Bar(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9,  object arg10)
        {
            Count += 10;
        }
    }
}