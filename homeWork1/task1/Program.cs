//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число 1: ");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1);
Console.Write("Введите число 2: ");
string strNum2 = Console.ReadLine();
int num2 = int.Parse(strNum2);
if(num1 > num2)
{
    Console.WriteLine($"max = {num1} min = {num2}");
}
else if(num1 < num2)
{
    Console.WriteLine($"max = {num2} min = {num1}");
}
else
{
    Console.WriteLine("Это одно и тоже число");
}
