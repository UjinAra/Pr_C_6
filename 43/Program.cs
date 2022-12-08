// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using static System.Console;
Clear(); 

int ReadFromConsole(string mess) // Метод ввода данных с консоли
{
    WriteLine (mess);
    return  Convert.ToInt32(ReadLine());
}

double b1 = ReadFromConsole("Введите b1");
double k1 = ReadFromConsole("Введите k1"); 
double b2 = ReadFromConsole("Введите b2");
double k2 = ReadFromConsole("Введите k2"); 

   double coordX =Math.Round(((b2-b1)/(k1-k2)),2);
   double coordY =Math.Round((k1*coordX+b1),2);
   
WriteLine ($"Координаты пересечения прямых ({coordX} ; {coordY})");