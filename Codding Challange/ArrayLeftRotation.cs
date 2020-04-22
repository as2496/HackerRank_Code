using System;
namespace Codding_Challange
{
    public class ArrayLeftRotation
    {
        /*
         * An array of integers An integer a,
         * the number of rotations d.
         * Left rotation of array
         */
        static int[] rotLeft(int[] a, int d)
        {

            int[] newA = new int[a.Length];
            for(int i = 0; i < a.Length; i++)
            {
                int newPos = (a.Length + (i - d)) % a.Length;
                newA[newPos] = a[i];
            }
            return newA;

        }
        /*
        static void Main(string[] args)
        {
          
            int d = 4;

            int[] a = new int[] { 1, 2, 3, 4, 5 };
            
            int[] result = rotLeft(a, d);

            Console.WriteLine(string.Join(" ", result));
        }*/
    }
}
