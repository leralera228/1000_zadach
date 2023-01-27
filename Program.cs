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
double d;
double l;
double p;
d = 1.0;
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
/*
// Task 10. Даны 2 нулевых числа. Найти сумму, разность, проиведение и частное их квадратов.
Console.WriteLine("Input a first number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number ");
int b = Convert.ToInt32(Console.ReadLine());
int sum = b + a;
int difference = a - b;
int squad = (a * a) / (b * b);
Console.WriteLine($"Сумма чисел равна {sum} , разность чисел равно {difference} , частное квадратов равно {squad}");
*/
/*
// Задача 1.

int l = 200;
int m = l / 100;
Console.WriteLine($"Полных метров в расстоянии {m}");
*/

//Задача 6.

// Console.WriteLine("Введите целое двухзначное число ");
// int a = Convert.ToInt32(Console.ReadLine());
// int dec = a / 10;
// int ed = a % 10;
// Console.WriteLine($"Десятки числа это {dec}, а еденицы {ed}");

//  Console.WriteLine("Введите пятизначное число ");
// int a = Convert.ToInt32(Console.ReadLine());
// int c1 = a / 10000;
// int c2 = (a / 1000)%10;
// int c4 = (a / 10)%10;
// int c5 = a % 10;
// bool res = c1 == c5 && c2 == c4;

// if (c1 == c5 && c2 == c4){
//     Console.WriteLine("да");
// }
// else{
//     Console.WriteLine("нет");
// }

// // Задача 21
//  Console.WriteLine("Введите координаты двух точек ");
// int a = Convert.ToInt32(Console.ReadLine());
// int x1;
// int x2;
// int y1;
// int y2;
// int z1;
// int z2;
// double d = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
// Console.WriteLine($"Расстоянием между двух точек в 3Д пространсве будует {d}");





// // Integer 8.
//  // Дано двухзначное число. Вывести число, полученое при перестановке цифр исходного числа.

// Console.WriteLine("Input a two - digit number ");
// int num = Convert.ToInt32(Console.ReadLine());

// int c1 = num / 10;
// int c2 = num % 10;
// Console.WriteLine($"Новым числом будет {c2}{c1}");

// // Integer 9.
//  // Даны 2 ненулевых числа. Найти сумму разность произведение частное их квадратов.\
//  // Тут я не понимаю как сделать так чтоб разность вычиталась от большего к меньшему.Почему именно а минус б.Как посавить условие чтобы вычиталось меньшее с большего
//  // Почему частное не сходится?
//  Console.WriteLine("Input a first non-zero number ");
//  int a = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine(" Input a second non-zero number ");
//  int b = Convert.ToInt32(Console.ReadLine());

//  int sum = (a * a) + (b * b);
//  int min = (a * a) - (b * b); 
//  int product = (a * a) * (b * b);
//  int quotient = (a * a) / (b * b);

//  Console.WriteLine($"Cумма это {sum} разность {min} это произведение это {product} чaстное это {quotient}");




// Integer 10.
//  // Даны 2 ненулевых числа. Найти сумму разность произведение частное их квадратов.\
//  // Тут я не понимаю как сделать так чтоб разность вычиталась от большего к меньшему.Почему именно а минус б.Как посавить условие чтобы вычиталось меньшее с большего
//  // Почему частное не сходится?
//  Console.WriteLine("Input a first non-zero number ");
//  int a = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine(" Input a second non-zero number ");
//  int b = Convert.ToInt32(Console.ReadLine());

//  int sum = (a * a) + (b * b);
//  int min = (a * a) - (b * b); 
//  int product = (a * a) * (b * b);
//  int quotient = (a * a) / (b * b);

//  Console.WriteLine($"Cумма это {sum} разность {min} это произведение это {product} чaстное это {quotient}");

// //Необходимо написать программу, которая принимает на вход координаты точки x, y и выдает номер четверти плоскости где эта точка находится

// int FindQuandrant(double x, double y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
//     return 0;
// }
// Console.Write("Input the first coordinate ");
// double xA = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input the second coordinate ");
// double yA = Convert.ToDouble(Console.ReadLine());


// int quadnum = FindQuandrant(xA,yA);
// Console.WriteLine($"The point A {xA},{yA} is on the {quadnum}");


//Необходимо написать программу, которая по заданому номеру четверти, показывает диапазон возможных координат
// в этой четверти


// // Дано трехзначное число.Вывести число полученое при прочтении исходного числа справа на лево.

// Console.WriteLine("Input a three number ");

// int num = Convert.ToInt32(Console.ReadLine());

// int ed = num % 10; 
// int dec = num % 100; 
// int dec1 = dec / 10; 
// int sot = num / 100; 
// Console.WriteLine($"Новое число {ed}{dec1}{sot}");

// // INTEGER 11
// //Дано целое число, больше 999. Используя одну операцию деления нацело
// // и одну операцию взятия остатка от деления, найти одну цифру, соответстувующую разряду сотен в записи этого числа.

// Console.WriteLine(" Input a number more than < 999 ");
// int num = Convert.ToInt32(Console.ReadLine());

// int dec = num / 100;
// int sot = dec % 10;

// Console.WriteLine($"Sot is {sot}");


// // Даны катеты прямоугольного треугольника а и б. Найти его гепотенузу и перриметр

// Console.WriteLine("Input katet a ");
// int cata = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input katet b ");
// int catb = Convert.ToInt32(Console.ReadLine());

// int c = (cata * cata) + (catb * catb);
// int p = c + cata + catb;
// Console.WriteLine($" Гепотенуза треугольника равна {c}, а его переметр раверн {p}");


// Begin 12. Даны катеты прямоугольного треугольника а и б. Найти его гепотенузу и перриметр

// Console.WriteLine("Input katet a ");
// int cata = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input katet b ");
// int catb = Convert.ToInt32(Console.ReadLine());

// int c = (cata * cata) + (catb * catb);
// int p = c + cata + catb;
// Console.WriteLine($" Гепотенуза треугольника равна {c}, а его переметр раверн {p}");

// Begin 13. Даны 2 круга с общим центром и радиусом R1 и R2 (R1 > R2); Найти площади этих кругов S1 и S2, а 
// также площадь S3 кольца внешний радиус которого равен R1, а внутренний радиус R2;

// Console.WriteLine("Input a big R ");
// int Rbig = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a small R");
// int Rsmall = Convert.ToInt32(Console.ReadLine());

// double p = 3.14;
// double s1 = p * (Rbig * Rbig);
// double s2 = p * (Rsmall * Rsmall);
// double s3 = s1 - s2;

// Console.WriteLine($"Площади кругов равны {s1} и {s2} , а площать кольца равна {s3}");

// // Begin 17. Даны 3 точки A,B,C на числовой оси. Найти длины отрезкой AC и BC. И их сумму.

// Console.WriteLine("Input point A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input poin B ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input poin C ");
// int c = Convert.ToInt32(Console.ReadLine());

// int ac = 



// Console.WriteLine ("Input a number ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("Input a count ");
// int count = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= count; i = i+1){
//     Console.Write(num);

// }

// for (int i = 1; i <= 5; i = i + 1)
// {
// //     Console.WriteLine(i);
// // }


// for ( int i = 10; i >= 0; i = i - 1)
// {
//     Console.WriteLine(i);
// }

// for (int i = 2; true; i += 2)
// {
//     Console.WriteLine(i);
// }

// Даны 2 целых числа А и B. (A < B). Вывести в порядке возрастания все целые числа, 
// расположеные между A и B. (Включая сами A и B)А также кол - во N этих чисел 
// // // 
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("Input A ");
//         int a = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Input B ");
//         int b = Convert.ToInt32(Console.ReadLine());
//         int k = 0;
//         for (int i = a; i <= b; i = i + 1)
//         {
//             Console.WriteLine(i);
//             k +=  1;
//         }
//         Console.WriteLine($" кол во раз {k}");
//     }
// 



// // For 3. Дано вещественное число - цена 1 кг конфет. Вывести 1, 2....10 кг конфет.

// Console.WriteLine("Input a price of sweet ");
// int pr = Convert.ToInt32(Console.ReadLine());


// {
//    for(int i = 1; i < 10; i++) 
    
//     Console.WriteLine($"цена {i} это {pr * i}");
// }

// // For 7.Даны 2 целых числа A и B. (A < B). Найти сумму всех целых чисел от A до B включительно.

// Console.WriteLine("Input number A "); 
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input number B "); 
// int b = Convert.ToInt32(Console.ReadLine());
// {
//     for(int i = a; i <= b; i = (i + 1) + i)
//     Console.WriteLine($"число {i}");
// }


// Console.WriteLine("Input number a");
// int a = Convert.ToInt32(Console.ReadLine());
//  if(a>0)
//  {
//     a = a + 1;
   
//  }
//  else
//  {
//     a = a - 2;
//  }
// //  Console.WriteLine($"{a}");

// Console.WriteLine("Input a number ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num % 2==0)
// {
//     Console.WriteLine($"четное");
// }
// else
// {
//     Console.WriteLine($"нечетное");
// // }
// Console.WriteLine("Input a number ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num>=10  && num<=99)
// {
//     Console.WriteLine($"двухзначое");
// }
// else 
// {
//     Console.WriteLine($"не двухзначное");
// }
// //Введите 3 числа и пусть программа ответит сколько их них положительных
// int i = 0;
// Console.WriteLine("Input a number ");
// int a = Convert.ToInt32(Console.ReadLine());
// if(a>0)
// {
//     i = i + 1;
// }
// Console.WriteLine("Input a number ");
// int b = Convert.ToInt32(Console.ReadLine());
// if(b>0)
// {
//     i = i + 1;
// // }
// // Console.WriteLine("Input a number ");
// // int c = Convert.ToInt32(Console.ReadLine());

// // if(c>0)
// // {
// //     i = i + 1;
// // }
// // Console.WriteLine($"{i}");


// // //Введите 3 числа и пусть программа ответит сколько их них положительных и сколько отрицателтных.
// // int i = 0;
// // int e = 0;
// // Console.WriteLine("Input a number ");
// // int a = Convert.ToInt32(Console.ReadLine());
// // if(a>0)
// // {
// //     i = i + 1;
// // }
// // if(a<0)
// // {
// //     e =  e + 1;
// // }
// // Console.WriteLine("Input a number ");
// // int b = Convert.ToInt32(Console.ReadLine());
// // if(b>0)
// // {
// //     i = i + 1;
// // }
// // if(b<0)
// // {
// //     e =  e + 1;
// // }
// // Console.WriteLine("Input a number ");
// // int c = Convert.ToInt32(Console.ReadLine());

// // if(c>0)
// // {
// //     i = i + 1;
// // }
// // if(c<0)
// // {
// //     e =  e + 1;
// // }
// // Console.WriteLine($"{i} и {e}");
// //IF7
// Console.WriteLine("Input a number ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input a number ");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a<b)
// {
//     Console.WriteLine("1");
// }
// if(b<a)
// {
//     Console.WriteLine("2");
// }
// if(a == b)
// {
//     Console.WriteLine("равны");
// }

//IF6. Даны 2 числа.Найти порядковый номер большего из них
// Console.WriteLine("Input a number one ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input a number two ");
// int num2 = Convert.ToInt32(Console.ReadLine());


// if(num1 > num2)
// {
//     Console.WriteLine("больше 1-е");
// }
// if(num2 > num1)
// {
//     Console.WriteLine("больше 2-е");
// }
 
//  Даны 2 переменные вещественного типа A и B. Перераспледелить значения данных

// Console.WriteLine("Input num1");
// int a = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Input num2");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a!=b)
// {
//    int sum = a + b;
//    a = sum; b = sum; 
// }
// else
// {
//     a = 0; b = 0;
// }
// Console.WriteLine($" {a} {b}");

//Даны 3 числа. Найти среднее из них (т е число расположеное между наименьшим и большим)

// Console.WriteLine("Input a number a ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input a number b ");
// int  b= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input a number c ");
// int c = Convert.ToInt32(Console.ReadLine());

// if(a>b && a<c)
// {
//     Console.WriteLine($"Среднее число {a}");
// }
// if(b>a && b<c)
// {
//     Console.WriteLine($"Среднее число {b}");
// }
// if(c>a && c<b)
// {
//     Console.WriteLine($"Среднее число {c}");
// }

// // Даны 2 переменные вещественного типа  A и B. Перераспределить значение данных переменных так, чтобы в A оказалось меньшее из значений, а в B
// // большее. Вывести новые значения переменных A и B.

// // Console.WriteLine("Input number A ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input number B ");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a<b)
// {
//     Console.WriteLine($"меньшее {a} большее {b}");
// }
// if(a>b)
// {

// }

// // Даны три переменные вещественного типа A B C. Если их значения упорядочены по возрастанию, то удвоить их;
// // в противном случае заменить значение каждой переменной на противоположное. Вывести новые значения переменных

// Console.WriteLine("Inpur a number A ");
// int a = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Inpur a number B ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Inpur a number C ");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a<b && b<c && c>a)
// {
//     a = a+a; b=b+b; c = c+c;
// }
// else
// {
//     a = -a; b = -b; c = -c;
// }
// Console.WriteLine($"{a} {b} {c}");

// // Даны три переменные вещественного типа A B C. Если их значения упорядочены по возрастанию или убыванию, то удвоить их;
// // в противном случае заменить значение каждой переменной на противоположное. Вывести новые значения переменных

// Console.WriteLine("Input a number A ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input a number B ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input a number C ");
// int c = Convert.ToInt32(Console.ReadLine());

// if(a<b && b<c && c>a)
// {
//     a=a+a; b=b+b; c=c+c;
// }
// if(c>b && b>a && a<c)
// {
//     c = c+c; b=b+b; a=a+a;
// }

// else
// {
//     a = -a; b = -b; c = -c;
// }
// Console.WriteLine($"{a} {b} {c}");

// Даны 3 целых числа. Одно из которых отлично от двух других, равных между собой. Определить порядковый номер числа,
// отличного от остальных

// Console.WriteLine("Inpur a number A ");
// int a = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Inpur a number B ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Inpur a number C ");
// int c = Convert.ToInt32(Console.ReadLine());

// int num = 2;
// if(a==b && a>c)
// {
//     c = 1;
// }
// if(a==c && a>b)
// {
//    b = 1;
// }
// if(b==c && b>a)
// {
//     c = 1;
// }
// Console.WriteLine($"{a} {b} {c}");
// Даны 4 целых числа. Одно из которых отлично от 3-ех других равных между собой. Найти порядковый номер отличного числа

// Console.WriteLine("Input a number A ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input a number B ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input a number C ");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input a number D ");
// int d = Convert.ToInt32(Console.ReadLine());

// if(a==b && a==c)
// {
//     Console.WriteLine($"{d} второе");
// }
// if(a==d && a==c)
// {
//     Console.WriteLine($"{b} второе");
// }
// if(b==d && d==c)
// {
//     Console.WriteLine($"{a} второе");
// }

//  Напишите програму которая по заданому номеру четверти показывает диапазон возможных координаn в этой четверти.

// x>0; y> 0

// Console.WriteLine("Input quand ");
// int quand = Convert.ToInt32(Console.ReadLine());

// {   
//     if (quand == 1)
//     Console.WriteLine("x+.....  y+.....");
//     if (quand == 2)
//     Console.WriteLine("x+..... и y-.....");
//     if (quand == 3)
//     Console.WriteLine("x-..... и y-.....");
//     if (quand == 4)
//     Console.WriteLine("x-..... и y+.....");

// }

// Напишите програму которая принимает на вход координаты 2-ух точек и находит расстояние межу ними в 2д пространстве

// Console.WriteLine("Input first point");
// int f = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input second point");
// int s = Convert.ToInt32(Console.ReadLine());

//  изменим второй элемент массива
// int[ ] numbers = {1,2,3,4,5};
// numbers [1] = 505; // изменяем значение второго элемента массива
 
// Console.WriteLine(numbers[1]);  // 505
// int[] numbers = { 1, 2, 3, 5};
 
// Console.WriteLine(numbers[numbers.Length - 1]);  // ? какой элемент с конца
// Console.WriteLine(numbers[numbers.Length - 2]);  // ?
// Console.WriteLine(numbers[numbers.Length - 3]);  // ?

// int[] numbers = { 1, 2, 3, 5};
 
// Console.WriteLine(numbers[^1]);  // 5 - первый с конца или последний элемент
// Console.WriteLine(numbers[^2]);  // 3 - второй с конца или предпоследний элемент
// Console.WriteLine(numbers[^3]);  // 2 - третий элемент с конца

// int[] numbers = { 1, 2, 3, 4, 5 };
// foreach (int i in numbers) //foreach  - для каждого
// {
//     Console.WriteLine(i);
// }
// int[] numbers = { 1, 2, 3, 4, 5 };
// for (int i = 0; i < numbers.Length; i++) // i++ это инкермент или последовательное увеличение некого числа i (в данном случае); for - условие
// {
//     Console.WriteLine(numbers[i]);
// }

// int[] numbers = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
// for (int i = 10; i < numbers.Length; i--)// декримент операция последовательного уменьшения
// {
//     Console.WriteLine(numbers[i]);
// }
// int[] numbers = { 1, 2, 3, 4, 5 };
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = numbers[i] * 2;
//     Console.WriteLine(numbers[i]);
// }

// int[] numbers = { 1, 2, 3, 4, 5 };
// int i = 0;
// while(i < numbers.Length)
// {
//     Console.WriteLine(numbers[i]);
//     i++; // в whie условие пишем после вывода на печать
// }

// int[] nums1 = new int[] { 0, 1, 2, 3, 4, 5 }; // одномерный массив
 
// int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } }; // двумерный массив

// Некоторые пути определения двухмерных массивов:
// int[,] nums1;
// int[,] nums2 = new int[2, 3];
// int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
// int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
// int[,] nums5 = new [,]{ { 0, 1, 2 }, { 3, 4, 5 } };
// int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };

// int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }};
// foreach (int i in numbers)
//     Console.Write($"{i} ");

//Задача 34: Задайте массив из 12 элементов от 9 до -9
// Найдите сумму отрицательных элементов массива

// int[] array = { 1, -3, 4, -2, 0, 10 };
// int negatives = 0;
// for (int i = 0; i < array.Length; i++)//объявление цикла for в котором подсчет элементов i начинается с 0
//     if (array[i] < 0)// условие: если послед элемент массива меньше нуля тогда...
//         negatives += array[i];// тогда в переменную отрицательных чисел суммиркется каждый последущий элемент массива
//         //"negatives += i" равно "negatives = negatives + i"
 
// Console.WriteLine(negatives);

//необходимо написать которая принимает на вход некоторое число и считает сумму чисел от 1 до этого числа
// 
// int GetSum(int num) // тут пишем что должны иметь на выходе (найти сумму)
// {
//     int sum = 0; // тут пока то что имеет (пока сумма равна ноль)

//     for(int current = 1; current <= num; current ++)// логическое условие
//     {
//         sum = sum + current;
//     }

//     return sum;
// }

// Console.WriteLine("Input a number ");
// int a = Convert.ToInt32(Console.ReadLine());

// int result = GetSum(a);// переменна - то что мы возвращаем
// Console.Write($"Sum of numbers from 1 to {a} is {result}");

//Напишите программу которая на вход берет число и находит кол-во цифр в числе

// int Sum(int num)
// {
//     int count = 0;
//     while (num > 0)
//     {
//         num = num/10;
//         count++;
//     }
//     return count;
// }
// Console.WriteLine("Input a number ");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = Sum(num);

// Console.WriteLine(result);
//Напишите программу которая на вход берет число и находит кол-во цифр в числе

// int GetSum(num)
// {
//     int current = num % 10;
//     {
//         for(int i = 0; i < 0; current+current)
//     }
// }


// Console.WriteLine("Input a number ");
// int num = Convert.ToInt32(Console.ReadLine());

// int c = num % 10;
// {
//     while(c<=0);
//     num = c+c;
// }
// Console.WriteLine($"сумма это {num}");
//Напишите программу которая на вход берет число и находит произведение этих чисел

// Console.WriteLine("Input a number ");
// int a = Convert.ToInt32(Console.ReadLine());

// int num = a % 10;
// int pr = num * num;
// {
//     while(num<0);
    
// }
// Console.WriteLine($"произведение чисел {a} - {pr}");

// int [] CreateRandomArray(int size,int minValue, int maxValue)// описание метода
// {
//     int[]array = new int[size];// выделяем память под массив

//     for(int i = 0; i < size; i++)
    
//      array[i] = new Random().Next(minValue, maxValue + 1);
//      return array;

// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// Console.Write("Input a number of elements ");
// int leght = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a min Value ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a max Value ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(leght, min, max);
// ShowArray(myArray);


//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//ввести 5-значное число
//разбить число на цифры и записать цифры в массив

int[] mas = new int[10];
Random gen = new Random();

for(int i = 0; i < 10; i++)
{
    mas[i] = gen.Next();
    Console.WriteLine(mas[i]);
}

