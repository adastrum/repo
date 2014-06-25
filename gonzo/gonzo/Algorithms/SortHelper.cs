namespace gonzo.Algorithms
{
    class SortHelper
    {
        private static int Partition(int[] array, int min, int max)
        {
            var marker = min;
            for (var i = min; i <= max; i++)
            {
                if (array[i] <= array[max])
                {
                    var temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker++;
                }
            }
            return marker - 1;
        }

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
            if (min >= max)
            {
                return;
            }
            var pivot = Partition(array, min, max);
            QuickSort(array, min, pivot - 1);
            QuickSort(array, pivot + 1, max);
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
