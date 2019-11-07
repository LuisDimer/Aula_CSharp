using System;

namespace _5_VariablesTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Signed Integral
            byte byteVariable; //Can store data in 8-bits [byte.MinValue = 0 byte.MaxValue = 255] 
            short shortVariable; // Store data in 2-bytes (16 bits) [short.MinValue = -32768  short.MaxValue =  32767]
            int intVariable; // 4-bytes (32 bits) [int.MinValue = -2147483648  int.MaxValue =  2147483647]
            long longVariable; // 8-bytes (64 bits) [long.MinValue = -9223372036854775808  long.MaxValue =  9223372036854775807]

            //Unicode characters
            char charVariable; // 2 bytes (16 bits) this represent a single character

            //Floating-point
            float floatVariable; // floating numbers have ~6-9 digits of precision
            double doubleVariable; // double variable have ~15-16 digits of precision

            //Boolean
            bool booleanVariable; // boolean variable can have two value, true or false

        }
    }
}