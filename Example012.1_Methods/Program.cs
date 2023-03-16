int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArrey(int[] array) // печать массива
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
                minPosition = j;
        }
        int temporary = array[i]; // в i позицию мы кладем тот этемент, который будет найден.
        array[i] = array[minPosition]; // обмен двух переменных местами
        array[minPosition] = temporary; // в минимальную позицию кладем элемент который был временным
    }
}
PrintArrey(arr);
SelectionSort(arr);

PrintArrey(arr);