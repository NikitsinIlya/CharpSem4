// String(char)
/*
string? stroka = Console.ReadLine(); // вопрос означает что значение будет не null
char x = '5'; // для символа одинарные ковычки
Console.WriteLine(stroka[0]);

string? stroka = Console.ReadLine();
Console.WriteLine(Convert.ToInt32(stroka[0].ToString())*10); // при переводе char в int мы получим его номер в utf8

Console.Clear();

Console.Write("Введите количество элементов : ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);  // [-10, 10 ] последняя цифра не входит
}
Console.WriteLine($"Результат: [{string.Join(" ,  ", array)}]"); // вывод массива без цикла!

// функции и процедуры (void)

void f(ref int n) // ref - передача значения по ссылке
{
    n = n + 5;
}

int n = 10;
f(ref n);
Console.WriteLine(n);


// Function(void)

void f(int[] n)
{
    n[0] = n[0] + 5;
}

int[] n = {1, 2, 3, 4, 5};
f(n);
Console.WriteLine(string.Join(" ", n));


// программа которая принимае 2 числа и выводит наибольшее

int f(int a, int b)
{
    if(a > b)
        return a;  // return прерывает функцию! если условие верно!
    return b;
}
int a = 1, b = 7;
int result = f(a, b);
Console.WriteLine(result);
*/
// Task 24
/*
Console.Clear();
Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine()); // double потому что при  делении теряем остаток
Console.WriteLine($"Результат: {(1 + n) / 2 * n}");


// task26

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
while (n > 0)
{
    n = n / 10;
    count++; 
}
Console.WriteLine(count);

// Task 28

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 1;
for (int i = 2; i <= n; i++)
    count = count * i;

Console.WriteLine(count);

// Task 30

Console.Clear();

int[] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);  // [-10, 10 ] последняя цифра не входит
}
Console.WriteLine($"Результат: [{string.Join(" ,  ", array)}]"); // вывод массива без цикла!
*/
