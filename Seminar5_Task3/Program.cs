int[] Array = GetRandomArray(4, 1, 100);
Console.WriteLine(string.Join(" , ", Array));
Console.WriteLine($"разница между максимальным элементом и минимальным  {GetSum(Array)} ");

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
  int max = Array[0];
  int min = Array[1];
  int res = 0;
  
  foreach(int el in Array)
  {
    if(el>max)
     max=el;
    else
     if(el<min)
     min=el;
  }
  res=max-min;  
  return res;
}

