string [] startArray = new string [] {"hello","2","world","1234",";-)","Belarus","cat"};
string [] newArray = new string [startArray.Length];
void SortArrayValue(string[] array1, string[] array2)
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[index] = array1[i];
            index++;
        }

    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
try
{
    Console.WriteLine("Начальный массив: ");
    PrintArray(startArray);
    SortArrayValue(startArray, newArray);
    Console.WriteLine("Отсортированный массив: ");
    PrintArray(newArray);
}
catch
{
    
    Console.WriteLine("error");
}