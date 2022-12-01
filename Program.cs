//Урок 6. Одномерные массивы. Продолжение
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 0)
{
   int [] m = new int [size];
   enternum(m);
   Console.WriteLine();
   positivnum(m);
}
else
   Console.WriteLine("Такого размера массива не существует");
void enternum (int [] arr)
{
   Console.WriteLine("Введите числа массива: ");
   for (int i = 0; i < arr.Length; i++)
   {
       int num = Convert.ToInt32(Console.ReadLine());
       arr[i] = num;
   }   
}
void positivnum (int [] arr)
{
   int result =0;
   for (int i = 0; i < arr.Length; i++)
   {
       if (arr[i] > 0)
       result = result + 1;
   }
   Console.WriteLine($"Введенных положительных чисел: {result}");
}