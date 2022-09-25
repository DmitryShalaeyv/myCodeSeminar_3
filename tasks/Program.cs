/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/

void Task_19()
{
    int FirstTwoNumbers(int num, int index = 2)
    {
        while (num / Math.Pow(10, index) > 1)
        {
            num /= 10;
        }
        return num;
    }
    
    Console.WriteLine("Введите пятизначное число -> ");
    string num_str = Console.ReadLine();
    int num = int.Parse(num_str);
    int x = num % 100;
    int y = FirstTwoNumbers(num);

    if(x / 10 == y % 10 && x % 10 == y / 10)
    {
        Console.WriteLine("Введенное Вами число " + num + " является палиндромом");
    }
    else
    {
        Console.WriteLine("Введенное Вами число " + num + " не является палиндромом");
    }
}

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/

void Task_21()
{
    double distanceBetweenTwoPoints(int x1, int y1, int z1, int x2, int y2, int z2)
    {
        double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
        double round_result = Math.Round(result, 2);
        return round_result;
    }

    Console.WriteLine("Введите координаты первой точки -> ");
    Console.Write("x1 -> ");
    string x1_str = Console.ReadLine();
    int x1 = int.Parse(x1_str);
    Console.Write("y1 -> ");
    string y1_str = Console.ReadLine();
    int y1 = int.Parse(y1_str);
    Console.Write("z1 -> ");
    string z1_str = Console.ReadLine();
    int z1 = int.Parse(z1_str);

    Console.WriteLine("Введите координаты второй точки -> ");
    Console.Write("x2 -> ");
    string x2_str = Console.ReadLine();
    int x2 = int.Parse(x2_str);
    Console.Write("y2 -> ");
    string y2_str = Console.ReadLine();
    int y2 = int.Parse(y2_str);
    Console.Write("z2 -> ");
    string z2_str = Console.ReadLine();
    int z2 = int.Parse(z2_str);

    double result = distanceBetweenTwoPoints(x1, y1, z1, x2, y2, z2);
    Console.WriteLine("Расстояние между точками - " + result);
}

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/

void Task_23()
{
    void Cub(int N)
    {
        for(int i = 1; i <= N; i++) {
            Console.WriteLine("Куб числа " + i + " равен: " + i * i * i);
        }
    }

    Console.WriteLine("Введите число N -> ");
    string N_str = Console.ReadLine();
    int N = int.Parse(N_str);
    Cub(N);
} 

Console.WriteLine("Введите номер задачи -> ");
string num_str = Console.ReadLine();
int num = int.Parse(num_str);

if(num == 19)
{
    Task_19();
    return;
} 
if(num == 21)
{
    Task_21();
    return;
} 
if(num == 23)
{
    Task_23();
    return;
} 
else Console.WriteLine("Неверный номер задачи");
