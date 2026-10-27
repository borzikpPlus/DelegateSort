namespace DelegateSort;

public static class Sorter
{
    public static void Sort(object[] data, Comparer comparer)
    {
        for (int i = 0; i < data.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < data.Length; j++)
            {
                if (comparer(data[minIndex], data[j]))
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                object temp = data[i];
                data[i] = data[minIndex];
                data[minIndex] = temp;
            }
        }
    }
}
