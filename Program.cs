// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] array = new int[10];

int cnt = 0; // CouNT - считать

Random rnd1 = new();

for (int i = 0; i < 10; i++)
{

    //Console.Write("Введите число: ");
    //array[i] = int.Parse(Console.ReadLine());

    array[i] = rnd1.Next(1, 101);

    if (array[i] > 19 && array[i] < 91)
    {
        cnt++;
    }

    Console.WriteLine("Элемент {0} = {1}", i, array[i]);

}

Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [20,90] = " + cnt);

// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array2 = new int[10];

int cnt2 = 0; // CouNT - считать

Random rnd2 = new();

for (int i = 0; i < 10; i++)
{

    array2[i] = rnd2.Next(1, 101);

    if (array2[i] % 2 == 0)
    {
        cnt2++;
    }

    Console.WriteLine("Элемент {0} = {1}", i, array2[i]);

}

Console.WriteLine("Количество чётных чисел в массиве = " + cnt2);


// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void mas(int a)
{
    Random rand = new Random();
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = rand.NextDouble();
        Console.Write($"{randomArray[i]:F2} ");
    }

}

double raz(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
    {
        if (max < randomArray[i])
            max = randomArray[i];
        if (min > randomArray[i])
            min = randomArray[i];
        i = i + 1;
    }
    return max - min;
}

mas(a);
Console.Write($"\n Разница между максимальным и минимальным элементов массива: {raz(randomArray):F2}");



// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

Console.Write("Введите натуральное число в диапазоне от 1 до 100 000: ");
int n = Convert.ToInt32(Console.ReadLine());
[] Array = new [n];

sum [array] = 0;
while (n != 0) {
    sum += n % 10;
    n /= 10;
}


