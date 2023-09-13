// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);
int startNum = 1;
while(startNum <= num)
{
    if(startNum % 2 == 0)
    {
        Console.WriteLine(startNum);
        startNum++;
    }
    else
    {
        startNum++;
    }
}