//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*Console.WriteLine("Введите количесто строк ");
int rows =Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Введите количесто столбцов ");
int colums = Convert.ToInt32(Console.ReadLine()!);

double[,] array = GetArray(rows, colums, -10, 10); //размерность массива
PrintArray(array); // печатать массив


double[,] GetArray(int m,  int n,  int minValue, int maxValue){ //скрипт для создания 2х мерного массива
    double [,] result = new double[m,n];
    Random rand = new Random();
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = rand.NextDouble()*(maxValue-minValue)+minValue;
        }

    }
    return result;

}

void PrintArray(double[,] Array){ //вывод 2х мерного массива
    for(int i = 0; i < Array.GetLength(0); i++){
        for(int j = 0; j < Array.GetLength(1); j++){
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}*/


//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, 
//что такого элемента нет

/* int[,] array = new int[10, 10];

for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
        array[i, j] = new Random().Next(0,10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца:");
int column = Convert.ToInt32(Console.ReadLine());
if ((rows < array.GetLength(0)) && (column < array.GetLength(1))){
    Console.WriteLine($"Значение указанного элемента: {array[rows, column]}");
}
else{
    Console.WriteLine("Элемент с указанными индексами не найден");
} */

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
//в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, 0, 10);
Console.WriteLine();
PrintArray(array);

Console.WriteLine();
GetAverage(array);

void GetAverage(int[,] Array){ // подсчёт среднего арефметического по типу дабл
    for (int i = 0; i < Array.GetLength(1); i++){
        double sum = 0;
        for (int j = 0; j < Array.GetLength(0); j++){
            sum = sum + Array[j, i];
        }
        Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {sum / Array.GetLength(1)}");
    }
}


int[,] GetArray(int m, int n, int minValue,int maxValue){ //скрипт для создания 2х мерного массива
    int [,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] Array){ //вывод 2х мерного массива
    for(int i = 0; i < Array.GetLength(0); i++){
        for(int j = 0; j < Array.GetLength(1); j++){
            Console.Write($" |{Array[i,j]}| ");
        }
        Console.WriteLine();
    }
}*/