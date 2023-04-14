// K = (x1-x2)^2 + (y1-y2)^2
// Math.Pow()
 

 Console.Write("Введите x1: ");
    int x1 = int.Parse(Console.ReadLine());
    //if (int.TryParse(text, out int number))

Console.Write("Введите x2: ");
    int x2 = int.Parse(Console.ReadLine());
    //if (int.TryParse(text, out int number))

Console.Write("Введите y1: ");
    int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите y2: ");
    int y2 = int.Parse(Console.ReadLine());

Console.WriteLine(FindLehgth(x1, x2, y1, y2));

double FindLehgth(int x1, int x2, int y1, int y2)
{
double result;
result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

return result;
}

