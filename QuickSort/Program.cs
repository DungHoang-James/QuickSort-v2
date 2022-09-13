
int[] array = { 2, 5, 1, 8, 3, 9, 0, 4, 7, 6 };

PrintResult(array, "Before sort");

QuickSort(array, 0, array.Length - 1);

PrintResult(array, "After sort");

static void QuickSort(int[] array, int leftIndex, int rightIndex)
{
    if (leftIndex >= rightIndex)
    {
        return;
    }

    Random r = new Random();
    int indexPivot = r.Next(leftIndex, rightIndex + 1);

    Swap(array, indexPivot, leftIndex);

    int pivot = leftIndex;

    int firstLarge = leftIndex + 1;

    for (int i = firstLarge; i <= rightIndex; i++)
    {
        if (array[i] < array[pivot])
        {
            Swap(array, firstLarge, i);
            firstLarge++;
        }
    }

    Swap(array, pivot, firstLarge - 1);
    pivot = firstLarge - 1;

    QuickSort(array, leftIndex, pivot - 1);
    QuickSort(array, pivot + 1, rightIndex);
}

static void Swap(int[] array, int index1, int index2)
{
    int tmpValue = array[index1];
    array[index1] = array[index2];
    array[index2] = tmpValue;
}

static void PrintResult(int[] array, string title)
{
    Console.WriteLine($"{title}");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write("\t");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}