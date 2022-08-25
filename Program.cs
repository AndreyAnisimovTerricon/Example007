Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n>99 ? n.ToString()[2] : "-" );
   if (n < 99)  Console.WriteLine("Третьей цифры нет");