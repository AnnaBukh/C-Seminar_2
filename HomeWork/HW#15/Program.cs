// напишите программу, которая принимает на вход цифру, обозначающую день недели 
// и проверяет, является ли этот день выходным

Console.Write("Введите день недели по порядку от 1 до 7 :");

int day = int.Parse(Console.ReadLine());

if (day == 6 || day == 7 )
{
    Console.Write($"день недели {day} является выходным");
}
else 
    Console.Write($"день недели {day} не является выходным");