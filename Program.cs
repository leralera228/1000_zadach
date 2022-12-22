/*
// Даны стороны прямоугольника а и b. Найти его площадь S = a * b и периметр P = 2 * (a + b)
int a;
int b;
int s;
int p;
a = 1;
b = 5;
s = a * b;
p = 2 * (a + b);
Console.WriteLine("Площадь сторон треугольника" + s + "а его периметр равен" + p);
*/

// Дан диаметр окружности d. Найти ее длинну L = П * d. п = 3.14
/*
int d;
int l;
double p;
d = 0;
p = 3.14;
l = p * d;
Console.WriteLine("Длина окружности явлется" + l);
*/
/*
// Дана длина ребра куба а. Найти объем куба V = а * а * а. И площадь его поверхности S = 6 * (a*a);

int a = 1;
int v = a * a * a;
int s = 6 * (a * a);

Console.WriteLine("Объем куба равен " + v + ", а его площадь равна " + s);
*/

// Task 6.
//  Даны длины ребер прямоугольного параллелепипеда a, b, c. Найти его объем и площадь его поверхности. 
// V = a * b * c и S = 2 * (a * b + a * c + c * b );
/*
int a = 1;
int b = 2;
int c = 3;
int v = a * b * c;
int s = 2 * (a * b + a * c + c * b);

Console.WriteLine($"Площадь параллелепипеда равна {v} , а его объем равен {s}");
*/
/*
// Task 7.
// Найти длину окружности L и площадь круга S заданого радиуса R: 
// L = 2 * п * R; S = п * (R * R).
Console.Write("Input a data ");
int r = Convert.ToInt32(Console.ReadLine());
int p = 3;
int l = 2 * p * r;
int s = p * (r * r);

Console.WriteLine($"Длина окружности равна {l},  а ее площадь равна {s}");
*/
/*
//8. Даны два числа a и b. Найти их среднее арифметическое a + b / 2;

Console.Write("Input a first number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number ");
int b = Convert.ToInt32(Console.ReadLine());
int avarage = (a + b) / 2;

Console.WriteLine($"Среднее арифметическое введенных чисел равно {avarage}");
*/

/*
// Task 9.
// Даны два неотрицательных числа a и b. Найти их среднее геометрическое, т.е квадратный корень из произведений
Console.WriteLine("Input a first positive number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second positive number ");
int b = Convert.ToInt32(Console.ReadLine());
int squareroot = (a * b) * (a * b);
Console.WriteLine($"Квадратный корень чисел {a} и {b } равен {squareroot}");
*/

// Task 10. Даны 2 нулевых числа. Найти сумму, разность, проиведение и частное их квадратов.
Console.WriteLine("Input a first number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number ");
int b = Convert.ToInt32(Console.ReadLine());
int sum = b + a;
int difference = a - b;
int squad = (a * a) / (b * b);
Console.WriteLine($"Сумма чисел равна {sum} , разность чисел равно {difference} , частное квадратов равно {squad}");










