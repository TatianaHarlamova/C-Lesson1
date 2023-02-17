Console.Write("Введите номер дня недели (от 1 до 7)  ");
int index = int.Parse(Console.ReadLine());
int[]array = {1,2,3,4,5,6,7};
int n = array.Length;

if (index < 6)
{
    Console.WriteLine("Нет ");
}
else 
{
    Console.WriteLine("Да");
}
