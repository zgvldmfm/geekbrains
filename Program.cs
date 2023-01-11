Console.WriteLine("Введите значение координаты x точки A" );
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координаты y точки A" );
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координаты z точки A" );
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координаты x точки B" );
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координаты y точки B" );
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координаты z точки B" );
int zb = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((Math.Pow(xa - xb,2)) + (Math.Pow(ya - yb,2)) + (Math.Pow(za - zb,2)));
Console.WriteLine($"Длинна отрезка:{Math.Round(result,2)}");