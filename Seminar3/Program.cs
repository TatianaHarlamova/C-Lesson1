//Задача 1

Console.WriteLine("Введите 5 значное число");
string a = Console.ReadLine();

if (a.Length < 5 || a.Length > 5)
  Console.WriteLine("Число не пятизначное");
else
    if (a[0] == a[4] && a[1] == a[3])
       Console.WriteLine("Это Полиндром");
    else
       Console.WriteLine("Это НЕ Полиндром");

