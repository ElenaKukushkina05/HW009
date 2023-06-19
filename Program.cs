// / ДЗ  64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// string GetStringOfNumbers(int end, int start)
// {
// // Базовый случай - выход
// if (end == start) return start.ToString();

// // Рекурсивный случай
// return end + ", " + GetStringOfNumbers(end - 1, start);
// }
// Console.WriteLine(GetStringOfNumbers(N, 1)); // start = N, end = 1



// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

 
// Console.WriteLine("Введите число M:");
// int digitalM = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число N:");
// int digitalN = Convert.ToInt32(Console.ReadLine());

// void DigitalSum (int digitalM, int digitalN, int sum)
// {
//     if (digitalM > digitalN) 
//     {
//         Console.WriteLine($"Сумма элементов в промежутке от M до N: {sum}"); 
//         return;
//     }
//     sum = sum + (digitalM++);
//     DigitalSum(digitalM, digitalN, sum);
// }

// DigitalSum(digitalM, digitalN, 0);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("Введите число M:");
// int firstDigit = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число N:");
// int secondDigit = Convert.ToInt32(Console.ReadLine());

// int AkkermanFunction(int firstDigit, int secondDigit)
// {
// if (firstDigit == 0) 
// {
//     return secondDigit + 1;
// }
// else if (secondDigit == 0) 
// {
//     return AkkermanFunction(firstDigit-1, 1);
// }

// else 
// {
//     return AkkermanFunction(firstDigit-1, AkkermanFunction(firstDigit, secondDigit-1));
// }
// }

// Console.Write($"Функция Аккермана {AkkermanFunction(firstDigit, secondDigit)} ");
