Console.Clear();

int size = 5;
string[] array = new string[size];
int number = 3;
Console.WriteLine($"Введите символы для заполнения массива размером {size}: ");
FillArray(array);
Console.Clear();
PrintArray(array);
Console.WriteLine();
PrintArray(CreateSecondArray(array));

void FillArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] array)
{
    Console.WriteLine();
    Console.WriteLine("[" + String.Join(", ", array) + "]");
}

int SortedArray(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length;i++)
    {
        if (array[i].Length <= number)
        {
            count++;
        }
            
    }
    return count;
}

string[] CreateSecondArray(string[] array)
{
    string[] SecondArray = new string[SortedArray(array)];

    for (int i = 0, j = 0; i < size; i++)
    {
          if (array[i].Length <= number)
          {
            SecondArray[j] = array[i];
            j++;
          }
    }
      return SecondArray;
}