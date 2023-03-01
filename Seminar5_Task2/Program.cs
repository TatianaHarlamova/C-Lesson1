int[] Array = GetRandomArray(4, 1, 100);
Console.WriteLine(string.Join(" , ", Array));
Console.WriteLine($"сумма нечетных элементов {GetSum(Array)}");

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
  for(int i=0; i<4; i++)
  {
    if (i% 2 > 0)
     count = count + Array[i];
    else
     count = count + 0;
  }
  return count;
}
