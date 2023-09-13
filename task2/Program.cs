//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число 1: ");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1);
Console.Write("Введите число 2: ");
string strNum2 = Console.ReadLine();
int num2 = int.Parse(strNum2);
Console.Write("Введите число 3: ");
string strNum3 = Console.ReadLine();
int num3 = int.Parse(strNum3);
if(num1 > num2 && num1 > num3)
{
    Console.WriteLine($"max = {num1}");
}
else if(num2 > num1 && num2 > num3)
{
    Console.WriteLine($"max = {num2}");
}
else if(num3 > num1 && num3 > num1)
{
    Console.WriteLine($"max = {num3}");
}
