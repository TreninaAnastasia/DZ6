//  Пользователь вводит с клавиатуры M
// чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;    
}
int num = Prompt("Введите число от -10 до 10: ");
int num1 = Prompt("Введите число от -10 до 10: ");
int num2 = Prompt("Введите число от -10 до 10: ");
int num3 = Prompt("Введите число от -10 до 10: ");
int num4 = Prompt("Введите число от -10 до 10: ");

Console.WriteLine ($"{num}, {num1}, {num2}, {num3}, {num4}");

void FindNumber (int a, int b, int c, int d, int e)
{
    int rez = 0;
        if (a <= 0) rez += 1;
        if (b <= 0) rez += 1;
        if (c <= 0) rez += 1;
        if (d <= 0) rez += 1;
        if (e <= 0) rez += 1;
    Console.WriteLine(rez);
}
FindNumber(num, num1, num2, num3, num4);