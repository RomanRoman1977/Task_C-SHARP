/* 18 Напишите программу которая
по заданному номеру четверти
покахывает диапазон возможных
координат точек в этой четверти (x и y)*/

Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

string Del(int number)
{
    if (number == 1) return "x = от 1 до N, y = от 1 до N";
    if (number == 2) return "x = от 1 до N, y = от -1 до -N";
    if (number == 3) return "x = от -1 до -N, y = от -1 до -N";
    if (number == 4) return "x = от 1 до N, y = от -1 до -N";
    return "Введена некорректная четверть";
}
string result = Del(num);
Console.WriteLine(result);

