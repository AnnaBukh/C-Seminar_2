// напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

Console.Write("Введите число :");
int number = int.Parse(Console.ReadLine());

int Remainder1 = number % 7;
int Remainder2 = number % 23;

//Console.WriteLine($"остаток от деления на 7 => {Remainder1}");
//Console.WriteLine($"остаток от деления на 23 => {Remainder2}");

//if (Remainder1 == 0)
//{
//   if (Remainder2 == 0) Console.Write($"число {number} делится без остатка на 7 и на 23");
//}
//else 
//{
//   Console.Write($"число {number} не делится без остатка на 7 и на 23");
//}

if (number % 7 == 0 && number % 23 == 0 )
{
    Console.Write($"число {number} делится без остатка на 7 и на 23");
}
else 
    Console.Write($"число {number} не делится без остатка на 7 и на 23");