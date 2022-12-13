/*Задача 19. Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.*/
// Console.WriteLine("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int digitOne = number / 10000;

// int digitTwo = (number % 10000) / 1000;

// int digitFour = (number % 100) / 10;

// int lastDigit = number % 10;

// void Palindrom()
// {
//     if(digitOne == lastDigit) 
//     {
//         if(digitTwo == digitFour) Console.WriteLine($"Супер! Наше число {number} является палиндромом.");
//         else Console.WriteLine("Наше число не палиндром.");
//     }
//     else Console.WriteLine("Наше число не палиндром.");

// }

// Palindrom();

/*Задача 21. Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними 
в 3D пространстве.*/
// void ThirdDimension(int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
//     Console.WriteLine($"Наше расстояние равно: {Math.Round(distance, 2)}");
// }
// Console.Write("Введите координаты x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// ThirdDimension(x1, x2, y1, y2, z1, z2);

/*Задача 23. Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.*/
// Console.WriteLine("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());

// void IceCube(int x)
// {

//     for (int i = 1; i <= x; i++)
//     {
//         Console.Write(i * i * i + " ");
//     }

// }
// IceCube(x);