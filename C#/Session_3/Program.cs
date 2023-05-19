using System;

namespace Assignment
{
    internal class Program
    {
        #region Passing Value Type Parameter
        /// Value Type
        //public static void Swap(int x,int y)
        //{
        //    Console.WriteLine("Swaping");
        //    int temp = x;
        //    x = y;
        //    y = temp;

        //} 

        ///Reference Type
        ///
        //public static void Swap(ref int x,ref int y)
        //{
        //    Console.WriteLine("Swaping");
        //    int temp = x;
        //    x = y;
        //    y = temp;

        //}
        #endregion

        #region Passing Reference Type Parameter

        ///Passing By Value


        //public static int SumArr( int[]Arr)
        //{
        //    int sum = 0;
        //   Arr[0]= 100;
        //    for (int i = 0; i < Arr?.Length; i++)
        //        sum += Arr[i];
        //    return sum;
        //} 

        //---------------------------------

        ///Passing By Reference

        //public static int SumArr(ref int[] Arr)
        //{
        //    int sum = 0;
        //    Arr=new int[] {4,5,6 };
        //    for (int i = 0; i < Arr?.Length; i++)
        //        sum += Arr[i];
        //    return sum;
        //}

        #endregion

        #region Passing By Out
        //public static void SumMul(int X,int Y,out int Sum,out float Mul)
        //{
        //    Sum = X + Y;
        //    Mul = X / Y;
        //} 

        /// Passing By Ref 
        //public static void SumMul(int X, int Y, ref int Sum, ref float Mul)
        //{
        //    Sum = X + Y;
        //    Mul = X / Y;
        //}
        #endregion

        [Flags]
        enum Permissions:byte
        {
            Read=1, Write=2,Delete=4,Execute=8

        }

        static void Main(string[] args)
        {
            #region Passing Value Type Parameters

            ///Value Type
            //int a = 5, b = 10;

            //Console.WriteLine($"A= {a}");
            //Console.WriteLine($"B= {b}");



            //Swap(a, b);

            //Console.WriteLine($"A= {a}");
            //Console.WriteLine($"B= {b}"); 
            //--------------------------------------------------------------------
            ///Reference Type

            //int a = 5, b = 10;

            //Console.WriteLine($"A= {a}");
            //Console.WriteLine($"B= {b}");



            //Swap(ref a,ref  b);

            //Console.WriteLine($"A= {a}");
            //Console.WriteLine($"B= {b}");

            #endregion

            #region Passing Reference Type Parameters
            ///Value Type

            //int[] numbers = { 1,2,3 };

            //SumArr( numbers);

            //Console.WriteLine(numbers[0]);//1
            //
            //------------------------------------------

            //Reference Type
            //int[] numbers = { 1, 2, 3 };

            //SumArr(ref numbers);

            //Console.WriteLine(numbers[0]);//4

            #endregion

            #region Passing By Out
            /// Passing By Out

            //int x = 10, y = 5, sum;
            //float mul;
            //SumMul(x, y, out sum, out mul);
            //Console.WriteLine($"Sum Two Numbers = {sum} and subtracting = {mul}"); 

            /// Passing By ref

            //int x = 10, y = 5, sum=0;
            //float mul=0;
            //SumMul(x, y, ref sum, ref mul);
            //Console.WriteLine($"Sum Two Numbers = {sum} and subtracting = {mul}");
            #endregion

            Permissions MyP = (Permissions)3;
            Console.WriteLine(MyP);

        }
    }
}
