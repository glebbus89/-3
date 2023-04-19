/* void ShowRange(int quad)
 {
    if(quad == 1) Console.WriteLine("x > 0 and y > 0");
    else if(quad == 2) Console.WriteLine("x < 0 and y > 0");
    else if (quad == 3) Console.WriteLine("x < 0 and y < 0");
    else if (quad == 4) Console.WriteLine("x > 0 and y < 0");
   else Console.WriteLine("Wrong number of quadrant!");
 }

Console.Write ("Input a number of quadrant: ");
int quadrant = Convert.ToInt32(Console.ReadLine());

ShowRange(quadrant);
 */
    
// Task. Напишите программу, которая принимает на вход координаты точки (X и Y), и 
// выдаёт номер четверти плоскости, в которой находится эта точка.

/*static int returnCoord(double x, double y)
{
if (x > 0 && y > 0) return 1;
else if (x < 0 && y > 0) return 2;
else if (x < 0 && y < 0) return 3;
else return 4;
}

Console.WriteLine("Plese, enter coord x");
double coordX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Plese, enter coord y");
double coordY = Convert.ToDouble(Console.ReadLine());
double terurnRes = returnCoord(coordX, coordY);
Console.WriteLine($"Ваша координатная плоскость {terurnRes}");
*/

// Task. Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.

/*void TablKvad (int N)
{
  int count=1;
  while (count<=N)
  {
  Console.WriteLine($"Квадрат {count} составляет - {count*count} ");
  count++;
  }
}

Console.WriteLine ("Введите значение - ");
int num = Convert.ToInt32(Console.ReadLine());
TablKvad (num);
*/

// Task. Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.

/*double Gipot (double x1, double y1, double x2, double y2)
{
  double distX = x2-x1;
  double distY = y2-y1;
  double result = Math.Sqrt(distX*distX + distY*distY);
  return result;
}

Console.Write ("Введите значение x1 - ");
int x1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write ("Введите значение y1 - ");
int y1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write ("Введите значение x2 - ");
int x2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write ("Введите значение y2 - ");
int y2 = Convert.ToInt32(Console.ReadLine()); 

double rez = Math.Round(Gipot (x1,y1,x2,y2),4);

Console.Write ($"Расстояние между точками 1 и 2 составляет - {rez}");
*/

// Homework.
// Task 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*Console.WriteLine("Введите значение ");
string num = Console.ReadLine();
int pal = num.Length;

if (pal == 5)
{
  if(num [0] == num [4] && num [1] == num [3])
  {
    Console.Write($"{num} - является Палиндромом");
  }
  else
  {
    Console.Write($"{num} - не является Палиндромом");
  }
}
*/

// Task 21. Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве. 
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*double Gipot (double x1, double y1, double z1, double x2, double y2, double z2)
{
  double dist = Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2);
  double result = Math.Sqrt(dist);
  return result;
}

Console.WriteLine("Введите значение x1 - ");
int x1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите значение y1 - ");
int y1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите значение z1 - ");
int z1 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите значение x2 - ");
int x2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите значение y2 - ");
int y2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите значение z2 - ");
int z2 = Convert.ToInt32(Console.ReadLine()); 

double rez = Math.Round(Gipot (x1,y1,z1,x2,y2,z2),2);

Console.WriteLine($"Расстояние между точками составляет - {rez}");
*/

// Task 23. Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/*void TablKub (int N)
{
  int count=1;
  while (count<=N)
  {
  Console.WriteLine($"Куб {count} составляет - {count*count*count} ");
  count++;
  }
}

Console.WriteLine ("Введите значение - ");
int num = Convert.ToInt32(Console.ReadLine());
TablKub (num);
*/











