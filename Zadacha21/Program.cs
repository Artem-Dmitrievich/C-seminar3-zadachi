// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//   x1  y1    x2  y2                             Корень из (x2 - x1)*2 + (y2 - y1)*2
// A (3, 6); B (2, 1) -> 5,09
// A (7, -5); B (1, -1) -> 7,21
// sqrt - корень из укзаанного числа в скобочках
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1)));
//split - за разделение
//round - округлить
//double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
//Console.WriteLine(string.Format("{0:F3}", distance));


Console.WriteLine("Расстояние между точками равно " + distance);
