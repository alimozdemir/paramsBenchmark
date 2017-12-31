namespace paramsBenchmark
{
    public unsafe class FooClassicUnsafe
    {
        public static int BarIntegerCount;

        public static void BarInteger(int arg1)
        {
            int* param = stackalloc int[1];
            param[0] = arg1;
            BarIntegerCount++;
        }

        public static void BarInteger(int arg1, int arg2)
        {
            int* param = stackalloc int[2];
            param[0] = arg1;
            param[1] = arg2;
            BarIntegerCount++;
        }

        public static void BarInteger(int arg1, int arg2, int arg3)
        {            
            int* param = stackalloc int[3];
            param[0] = arg1;
            param[1] = arg2;
            param[2] = arg3;
            BarIntegerCount++;
        }

        public static void BarInteger(int arg1, int arg2, int arg3, int arg4)
        {
            int* param = stackalloc int[4];
            param[0] = arg1;
            param[1] = arg2;
            param[2] = arg3;
            param[3] = arg4;
            BarIntegerCount++;
        }

        public static void BarInteger(int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            int* param = stackalloc int[5];
            param[0] = arg1;
            param[1] = arg2;
            param[2] = arg3;
            param[3] = arg4;
            param[4] = arg5;
            BarIntegerCount++;
        }

        public static void BarInteger(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
        {
            int* param = stackalloc int[6];
            param[0] = arg1;
            param[1] = arg2;
            param[2] = arg3;
            param[3] = arg4;
            param[4] = arg5;
            param[5] = arg6;

            BarIntegerCount++;
        }

        public static void BarInteger(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
        {
            int* param = stackalloc int[7];
            param[0] = arg1;
            param[1] = arg2;
            param[2] = arg3;
            param[3] = arg4;
            param[4] = arg5;
            param[5] = arg6;
            param[6] = arg7;

            BarIntegerCount++;
        }

        public static void BarInteger(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8)
        {
            int* param = stackalloc int[8];
            param[0] = arg1;
            param[1] = arg2;
            param[2] = arg3;
            param[3] = arg4;
            param[4] = arg5;
            param[5] = arg6;
            param[6] = arg7;
            param[7] = arg8;
            BarIntegerCount++;
        }

        public static void BarInteger(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9)
        {
            int* param = stackalloc int[9];
            param[0] = arg1;
            param[1] = arg2;
            param[2] = arg3;
            param[3] = arg4;
            param[4] = arg5;
            param[5] = arg6;
            param[6] = arg7;
            param[7] = arg8;
            param[8] = arg9;
            BarIntegerCount++;
        }

        public static void BarInteger(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9,  int arg10)
        {
            int* param = stackalloc int[10];
            param[0] = arg1;
            param[1] = arg2;
            param[2] = arg3;
            param[3] = arg4;
            param[4] = arg5;
            param[5] = arg6;
            param[6] = arg7;
            param[7] = arg8;
            param[8] = arg9;
            param[9] = arg10;

            BarIntegerCount++;
        }

 
    }
}