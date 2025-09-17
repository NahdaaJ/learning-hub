// LINEAR SEARCHING ------------------------------------------------------------------------------
// I've messed with removing/adding number of elements
// I've messed with searching at the start of the array and at the end of the array
// For small data sets (I tried less than 20 elements), it doesn't really matter
// O(n) time complexity
Console.WriteLine("LINEAR SEARCH -----------------------------------------------------------");

int[] myArray = { 6, 3, 7, 23, 6456, 2, 67, 8, 3, 7, 45, 1, 8, 2, 67, 2, 56, 8 };

var stopwatch = System.Diagnostics.Stopwatch.StartNew();
int index = linearSearch(myArray, 56);
stopwatch.Stop();
Console.WriteLine($"Elapsed time: {stopwatch.Elapsed.TotalMilliseconds} ms");

Console.WriteLine(index);

static int linearSearch(int[] array, int element)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == element)
        {
            return i;
        }
    }

    return -1;
}

// BINARY SEARCHING ------------------------------------------------------------------------------
Console.WriteLine("\n\nBINARY SEARCH -----------------------------------------------------------");

int[] myArray2 = { 0, 5, 6, 9, 10, 40, 50 };

Console.WriteLine(BinarySearch(myArray2, 50));

static int BinarySearch(int[] array, int targetValue)
{
    bool foundNum = false;
    int index = -1;
    int minIndex = 0;
    int maxIndex = array.Length - 1;

    while (!foundNum && minIndex <= maxIndex)
    {
        int middleIndex = (minIndex + maxIndex) / 2;

        if (array[middleIndex] == targetValue)
        {
            index = middleIndex;
            foundNum = true;
        }
        else if (array[middleIndex] > targetValue)
        {
            maxIndex = middleIndex - 1;
        }
        else
        {
            minIndex = middleIndex + 1;
        }
    }

    return index;
}