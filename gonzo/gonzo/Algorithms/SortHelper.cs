using System;

namespace gonzo.Algorithms
{
    class SortHelper
    {
        public static void BubbleSort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void QuickSort(int[] array, int min, int max)
        {
            var i = min;
            var j = max;
            var middle = array[(i + j) / 2];
            while (i <= j)
            {
                while (array[i] < middle) i++;
                while (array[j] > middle) j--;
                if (i <= j)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (j > min) QuickSort(array, min, j);
            if (i < max) QuickSort(array, i, max);
        }

        public static void InsertSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var current = array[i];
                var j = i - 1;
                while (j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    array[j] = current;
                    j--;
                }
            }
        }
    }
}
