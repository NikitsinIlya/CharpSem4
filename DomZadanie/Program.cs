﻿Console.Clear();

//Задача 25:
/*
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Math.Pow(ЗАПРЕЩЕНО)
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine("Введите число A: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int c = 1;
for( int i = 0; i < n2 ; i++)
    c = c * n1;
Console.WriteLine($"{n1} в степени {n2} =  {c}");

*/

//Задача 27: 

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
Console.WriteLine("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int del = 0;
while( n1 > 0)
{
    del = n1 % 10;
    sum = sum + del;
    n1 = n1 / 10;
}
Console.WriteLine($"Сумма цифр равна {sum}");
*/

//Задача 29: 
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран(ввод пользователя с клавиатуры).
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
/*
Console.Write("Введите количество элементов : ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите данные массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Результат: [{string.Join(" , ", array)}]"); // вывод массива без цикла!
*/

// Суперсдвиг
/*
Console.Write("Введите количество элементов : ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите данные массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Массив: [{string.Join(" , ", array)}]"); 
Console.WriteLine("Введите сдвиг: ");
int zdvig = Convert.ToInt32(Console.ReadLine()), z1 = 0;
if(zdvig > 0 ) 
 {
    for( int count = 0; count < zdvig ; count++)
    {
        z1 = array[n - 1];
        for(int k = n - 1; k > 0; k-- ) array[k] = array[k - 1];
        array[0] = z1;
    }
 }
 else if(zdvig < 0)
 {
 for( int count = n - 1; count > 1 ; count--)
    {
        z1 = array[0];
        for(int k = 0; k < n - 1 ; k++ ) array[k] = array[k + 1];
        array[n - 1] = z1;
    }
 }   
 Console.WriteLine($"Результат сдвига {zdvig}: [{string.Join(" , ", array)}]");

*/

// Гипотеза Гольдбаха )) не решил
/*
Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine()), n1 = 1, n2 = 0, p1 = 2, count = 0; 
double sqrtn = Math.Round(Math.Sqrt(n));

for( int i = 2; i < n/2; i++)
{
    n1 = i;
    n2 = n - i;
    while(p1 <= sqrtn )
    {
        if(n1 % p1 != 0 && n2 % p1 != 0)
        {
            Console.WriteLine($"{n1} , {n2}");
            break;
        }
        
        p1++;
    }
    p1 = 2;
 
}
*/
// решение гипГольдбах
int n = Convert.ToInt32(Console.ReadLine());
int countDel = 0, i, j, k, m;
for (i = 2; i <= n / 2; i++)
{
countDel = 0;
for (j = 2; j <= i / 2; j++)
{
if (i % j == 0)
countDel++;
}
if (countDel == 0)
{
m = n - i; // 992 - 73 = 919
for (k = 2; k <= (m + 1) / 2; k++)
{
if (m % k == 0)
countDel++;
}
if (countDel == 0)
{
Console.WriteLine($"{i} {m}");
return;
}
}
}