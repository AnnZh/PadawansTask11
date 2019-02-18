using System;

namespace PadawansTask11
{
    public static class ArrayExtensions
    {
        public static int? FindIndex(double[] array, double accuracy)
        {
            // put your code here
            //throw new NotImplementedException();

            if (array.Length < 3)
                throw new ArgumentException();


            double left = array[0];
            double right = 0;

            for (int i = 2; i < array.Length; i++)
            {
                right = right + array[i];
            }

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (left == right && left >= 0 && left <= 1)
                { 
                    return i;
                }
                left = left + array[i];
                right = right - array[i + 1];
            }

            return null;
        }
    }
}
