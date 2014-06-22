namespace gonzo.Algorithms
{
    class SearchHelper
    {
        private const int KeyNotFound = -1;

        private static int GetMiddle(int min, int max)
        {
            return min + (max - min) / 2;
        }

        public static int LinearSearch(int[] array, int key)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(key))
                {
                    return i;
                }
            }
            return KeyNotFound;
        }

        public static int BinarySearch(int[] array, int key, int min = 0, int max = 0)
        {
            while (max >= min)
            {
                if (max == 0)
                {
                    max = array.Length;
                }
                var middle = GetMiddle(min, max);
                if (array[middle] == key)
                {
                    return middle;
                }
                if (array[middle] < key)
                {
                    min = middle + 1;
                }
                else
                {
                    max = middle - 1;
                }
            }
            return KeyNotFound;
        }
    }
}
