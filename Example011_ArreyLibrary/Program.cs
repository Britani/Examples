// void FillArray(int[] coll)
// {
//     int length = coll.Length;
//     int index = 0;
//     while (index < length)
//     {
//         coll[index] = new Random().Next(1, 10);
//         index++;
//     }
// }
// void PrintArrey(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < 0)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

//  int[] array = new int[10]; // дословно:Создай новый массив в котором будет 10 элементов.по умолчанию он будет заполнен 0

// FillArray(array);
// PrintArrey(array);


void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1;
//     while(index < count)
//     {
//         if(collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }
int[] array = new int[10];

FillArray(array);
// array[4] = 4;
// array[6] = 4;
PrintArray(array);
// Console.WriteLine();
// int pos = IndexOf(array, 444);
// Console.WriteLine(pos);