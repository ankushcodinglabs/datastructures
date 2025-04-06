static bool BinarySearch(int[] array, int number)
{
    int min = 0;
    int max = array.Length - 1;
    while (min <= max) {
        int middle = (min + max) / 2;
        if (array[middle] == number) {
            return true;
        } else if (array[middle] < number) {
            min = middle + 1;
        } else {
            max = middle - 1;
        }
    }

    return false;
}

Console.WriteLine("An implementation for binary search in C#");

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine($"Searching number 3: {BinarySearch(array, 3)}");
