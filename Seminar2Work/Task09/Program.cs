// Напишите программу, которая выводит 
// случайное число из отрезка [10,99] и показывает 
// наибольшую цифру числа

//получаем случайно целове число, команда выдает псевдослучайное число в переменную number:
int number =  new Random().Next(10, 100); // до 100 , потому что последнне число не входит в диапазон
//посмотрим , что мы получаем :
Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");

//получаем по отдельности каждую цифру числа, создав для каждой цифры переменную:
int firstDigit = number / 10; // делением на 10 
int secondDigit = number % 10; // остаток от деления на 10 

//if (firstDigit == secondDigit) Console.WriteLine("Цифры равны");
//else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} => {firstDigit}");
//else Console.WriteLine($"Наибольшая цифра числа {number} => {secondDigit}");

// можно через условный/тернарный оператор:
//int result = firstDigit > secondDigit ? firstDigit : secondDigit; 
//Console.WriteLine($"Наибольшая цифра числа {number} => {result}");

//string result = firstDigit == secondDigit ? "Цифры равны" : firstDigit > secondDigit ? firstDigit.ToString() : secondDigit.ToString();
//Console.WriteLine($"Наибольшая цифра числа {number} => {result}");

// реализация через МЕТОД:

int MaxDigit(int num) // обращение к глобальной строке - к шестой строке
{
 int firstDigit = num / 10; 
 int secondDigit = num % 10; 
 //string result = firstDigit > secondDigit ? firstDigit : secondDigit;
 //return result;
 if (firstDigit == secondDigit) return 0;
 return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int result = MaxDigit(number);
string res = result == 0 ? "Цифры равны" : result.ToString();

Console.WriteLine($"Наибольшая цифра числа {number} => {res}");
