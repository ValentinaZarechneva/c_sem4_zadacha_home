// Задача 27: Напишите программу, которая принимает на вход
//  число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int len = Length(x);
int Length(int x)  //считаю количество цифр в числе
{
int index = 0;
while (x > 0)
{
x = x / 10;
index++;
}
return index;
}

int sum(int x, int len)   
{
int sum = 0;
for (int j = 0; j <= len; j ++)
{
sum = sum + x % 10;
x = x / 10;

}
return sum;
}
Console.Write($"Сумма цифр в числе {x} равно: {sum(x, len)} ");
