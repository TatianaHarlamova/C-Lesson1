int[] Array = GetRandomArray(4, 100, 999);
Console.WriteLine(string.Join(" , ", Array));
Console.WriteLine($"количество четных элементов {GetSum(Array)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(minValue, maxValue + 1);
  }
  return result;
}

int GetSum(int[] Array)
{
  int count = 0;
  foreach (int i in Array)
  {
    if (i % 2 == 0)
     count = count + 1;
    else
     count = count + 0;
  }
  return count;
}

