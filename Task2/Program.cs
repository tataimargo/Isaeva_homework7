//  Задайте произвольный массив. 
//  Выведете его элементы, начиная с конца.

int[] array = arbitraryArray(7, 7, 0);
System.Console.WriteLine($"Произвольный массив => [{PrintArray(array)}]");
System.Console.WriteLine($"Перевернутый массив => [{PrintArray(ReverseArray(array, array.Length - 1))}]");
int[] arbitraryArray(int size, int max, int min)
{
    int[] array = new int[size];
    Random rand = new();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}
 string PrintArray(int[] array)
{
    return string.Join(", ", array);
}
 int[] ReverseArray(int[] array, int index)
{

    if (index <= 0)
    {
        return array;
    }
    int temp = array[index];
    array[index] = array[array.Length - index - 1];
    array[array.Length - index - 1] = temp;
    return ReverseArray(array, index -= 2);
}