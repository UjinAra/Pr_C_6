// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear(); 

string  ReadFromConsole (string mess) // Метод ввода данных с консоли
{
    WriteLine (mess);
    return Convert.ToString(ReadLine());
}

string strMass = ReadFromConsole ("Введите массив чисел через запятую");

int[] dataN = strMass.Split(',')
                     .Select(x=> int.Parse(x))
                     .ToArray();
int j=0;
for (int i=0; i < dataN.Length; i++)
{
    if (dataN[i]>0)
    {
        j=j+1;
    }
}
WriteLine($"Количество введенных чисел больше 0 - {j} ");
