namespace paramsBenchmark
{
    public class FooClassicWithArray
    {
        public static int BarObjectCount;
        #region BarObject
        public static void BarObject(object arg1)
        {
            BarObjectCount++;
            var p = new object[] { arg1 };
        }

        public static void BarObject(object arg1, object arg2)
        {
            BarObjectCount++;
            var p = new object[] { arg1, arg2 };
        }

        public static void BarObject(object arg1, object arg2, object arg3)
        {
            BarObjectCount++;
            var p = new object[] { arg1, arg2, arg3 };
        }

        public static void BarObject(object arg1, object arg2, object arg3, object arg4)
        {
            BarObjectCount++;
            var p = new object[] { arg1, arg2, arg3, arg4 };
        }


        public static void BarObject(object arg1, object arg2, object arg3, object arg4, object arg5)
        {
            BarObjectCount++;
            var p = new object[] { arg1, arg2, arg3, arg4, arg5 };
        }

        public static void BarObject(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6)
        {
            BarObjectCount++;
            var p = new object[] { arg1, arg2, arg3, arg4, arg5, arg6 };
        }

        public static void BarObject(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7)
        {
            BarObjectCount++;
            var p = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7 };
        }

        public static void BarObject(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8)
        {
            BarObjectCount++;
            var p = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8 };
        }

        public static void BarObject(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9)
        {
            BarObjectCount++;
            var p = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9 };
        }

        public static void BarObject(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9,  object arg10)
        {
            BarObjectCount++;
            var p = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10 };
        }
        #endregion
    }
}