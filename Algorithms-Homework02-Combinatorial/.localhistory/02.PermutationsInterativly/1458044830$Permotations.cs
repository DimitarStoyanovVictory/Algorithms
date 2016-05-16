namespace PermutationsInterativly
{
    class Permotations
    {
        static void Main()
        {
            //int n = 4;

            //var array = Enumerable.Range(1, n).ToArray();

            //for (int indexRow = 1; indexRow < array.Length; indexRow++)
            //{
            //    for (int indexCol = indexRow; indexCol < array.Length; indexCol++)
            //    {
            //        Console.WriteLine();
            //    }
            //}

            int n = 3;

            var a = new int[n];
            var p = new int[n + 1];

            int i;
            int j;
            int temp;


            for (int index = 0; index < n; index++)
            {
                a[index] = index + 1;
                p[index] = index;
            }

            i = 1;
            while (i < n)
            {
                p[i]--;
                j = i % 2 * p[i];
                temp = a[j];
                a[j] = a[i];
            }

        }
    }
}
