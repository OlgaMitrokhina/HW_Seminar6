// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
//  Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



int count = 0;
int n=0;
string s = "";
while (s != "stop")
{

Console.WriteLine("Введите число (через enter), когда надоест вводить числа - введите stop: ");
s = Console.ReadLine();
if (s != "stop")
{
n = int.Parse(s);
if (n > 0)
count++;
}
}
Console.WriteLine("Количество элементов > 0: "+count.ToString());
