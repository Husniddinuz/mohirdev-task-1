System.Console.Write("Radiusni kiriting: ");
double radius = System.Convert.ToDouble(System.Console.ReadLine());

double pi = System.Math.PI;
double S = pi * System.Math.Pow(radius, 2);
double L = 2 * pi * radius;

System.Console.WriteLine($"S={S}, L={L}");