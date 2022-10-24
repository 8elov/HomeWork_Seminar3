// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

string CheckPalindrome(int number)
{
    string solution = " ";
    if (number > 9999 && number < 100000)
    {
        int first = number / 10000;
        int second = number / 1000 % 10;
        int fourth = number / 10 % 10;
        int fifth = number % 10;

        if (first == fifth && second == fourth)
        {
            solution = "Является палиндромом";
        }
        else
        {
            solution = "Не является палиндромом";
        }        
    }
    else
    {
        solution = "Необходимо ввести пятизначное число";
    }
    
    return solution;
}

string solution = CheckPalindrome(num);
Console.WriteLine(solution);