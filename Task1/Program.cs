// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке
// от M до N. Использовать рекурсию

System.Console.WriteLine("Введите любое число из заданного диапазона");
int num = Convert.ToInt32(Console.ReadLine());
int М = 34;
int N = 50;

PrintNumbers ( М, num );

void PrintNumbers(int MNum, int NNum)
{
    if(MNum> N)
    {
        return;
    }

    System.Console.Write(MNum+" ");

    PrintNumbers(MNum+1, NNum);
}

