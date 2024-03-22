namespace ArrayManagement_2
{
    public class ArraySorter
    {
        public static int FindIndexOfMin(int[] num, int fromI, int toI)
        {
            int index = Array.FindIndex(num, fromI, toI, n => n == num.Min());

            //Console.WriteLine($"L' indice del valore più piccolo di numeri[] è {index}");
            return index;
        }



        public static void SwapElements(int[] array, int i, int j)
        {
            if (array.Length > 0)
            {
                int element = array[i];
                array[i] = array[j];
                array[j] = element;
            }

            //Console.WriteLine("Swap elements :");

            foreach (var numero in array)
            {
                Console.Write(" " + numero);
            }
            //return true;
        }



        public static bool SortArray(int[] array)
        {

            Array.Sort(array);
            foreach (var numero in array)
            {
                Console.WriteLine(numero);
            }

            return true;
        }

    }
}
