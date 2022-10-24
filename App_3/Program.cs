// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void PrintCubesToConsole(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(i * i * i);
    }
}

PrintCubesToConsole(3);