using System;

namespace Sort_Call
{
    class Program
    {

        public static void Min_Max_Value(int[] array)
        {

            int minValue = array[0];
            int maxValue = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                    minValue = array[i];
                if (array[i] > maxValue)
                    maxValue = array[i];
            }
            Console.WriteLine($"Минимальное значение: {minValue}  Максимальное значение :{ maxValue}");
        }

        public static void Sort_Accetp(int[] array)
        {
            int minValue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] < minValue)
                    array[i] = minValue;
                if (array[i] < minValue)
                    minValue = i;
                i = 0;
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            
        }

        public static void Main(string[] args)
        {

            int[] array = { 12, 54, 11, 45, 99, 8, 54, 31, 30, 275, 187, 1 };
            //Min_Max_Value(array);
            Sort_Accetp(array );
        }
    }
}