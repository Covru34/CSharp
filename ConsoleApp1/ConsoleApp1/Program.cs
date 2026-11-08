using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Bogus;

Faker myFaker = new Faker("uk");

Console.InputEncoding = Encoding.UTF8; //5 Всі букви 'і' замінялися на знаки питання
Console.OutputEncoding = Encoding.UTF8;

//Console.WriteLine("Привіт, мене звати Паблін"); //1

//Console.WriteLine("Monster energy Bad Apple");//2
//Console.WriteLine("Terraria");
//Console.WriteLine("Пінкі Пай");

//Console.Write("Добре їсти - ");//3
//Console.Write("Добре спати?\n");

//Console.WriteLine("   *");//4
//Console.WriteLine("  ***");
//Console.WriteLine(" *****");
//Console.WriteLine("*******");
//Console.WriteLine("  ***");

//int age = 12;//1
//decimal cost = 50;
//double height = 1.83;
//char name = 'P';
//string city = "Moskva";
//Console.WriteLine("Вік учня: " + age);
//Console.WriteLine("Ціна буханки хліба в грн: " + cost);
//Console.WriteLine("Зріст в метрах: " + height);
//Console.WriteLine("Перша літера імені: " + name);
//Console.WriteLine("Назва міста: " + city);

//int a = 17;//2 
//int b = 5;
//Console.WriteLine($"{a} + {b} = {a + b}");
//Console.WriteLine($"{a} - {b} = {a - b}");
//Console.WriteLine($"{a} * {b} = {a * b}");
//Console.WriteLine($"{a} / {b} = {a / b}"); // так як змінна int, то дробове число заокруглюється до цілого
//Console.WriteLine($"{a} / 0.5 = {a / 0.5}");

//Console.WriteLine(byte.MaxValue);//3
//Console.WriteLine(short.MinValue);
//Console.WriteLine(int.MaxValue);
//Console.WriteLine(long.MaxValue);
////byte x = 256; // вибило помилку

//Console.WriteLine("=== Класний журнал ===");//4
//string name = "Rainbow Dash";
//byte clas = 11;
//int m1 = 4, m2 = 2; // по 12 бальній
//double arithmetic_mean = (m1 + m2) / 2.0;
//Console.Write($"Ім'я учня: {name}\nКлас: {clas}\n");
//Console.WriteLine("Середній бал: " + arithmetic_mean);

//Console.WriteLine("=== Лотерея ===");//5
//string name = "Sasavot";
//decimal cost = 20.00m;
//byte tikets = 2;
//int luckyNumber= 3;
//char ch = '*';
//Console.Write($"***************************\n" +
//              $"*  Гравець: {name}        *\n" +
//              $"*  Ціна: {cost}              *\n" +
//              $"*  Щасливе число: {luckyNumber}       *\n");

//Console.WriteLine("Напиши своє їм'я та місто");//1
//string name = Console.ReadLine();
//string sity = Console.ReadLine();
//Console.WriteLine("Привіт " + name + " З міста " + sity);

//Console.WriteLine("Напишіть два цілих числа: ");//2
//string temp = Console.ReadLine();
//int a = int.Parse(temp);
//temp = Console.ReadLine();
//int b = int.Parse(temp);
//Console.WriteLine(a + b);

//Console.WriteLine("Напишіть радіус кола: ");//3
//string temp = Console.ReadLine();
//double r = double.Parse(temp);
//Console.WriteLine($"Довжина кола: {2 * 3.14 * r}");
//Console.WriteLine($"Площа кола: {3.14 * r}");

//Console.WriteLine("=== Класний журнал ===");//4
//Console.WriteLine("Введіть ім'я, клас та дві оцінки учня: ");
//string name = Console.ReadLine();
//string temp = Console.ReadLine();
//int clas = int.Parse(temp);
//temp = Console.ReadLine();
//int m1 = int.Parse(temp);
//temp = Console.ReadLine();
//int m2 = int.Parse(temp);
//double arithmetic_mean = (m1 + m2) / 2.0;
//Console.Write($"Ім'я учня: {name}\nКлас: {clas}\n");
//Console.WriteLine("Середній бал: " + arithmetic_mean);

//Console.WriteLine("=== Лотерея ===");//5
//Console.WriteLine("Введіть своє ім'я, щасливе число та кількість квитків: ");
//string name = Console.ReadLine();
//string temp = Console.ReadLine();
//int luckyNumber = int.Parse(temp);
//temp = Console.ReadLine();
//int tikets = int.Parse(temp);
//decimal cost = 20.00m;
//decimal costAll = cost * tikets;
//char ch = '*';
//Console.Write($"***************************\n" +
//              $"*  Гравець: {name}        *\n" +
//              $"*  Ціна: {cost}              *\n" +
//              $"*  Щасливе число: {luckyNumber}       *\n");
//Console.WriteLine($"{name}, до сплати: {costAll}грн");

//Console.WriteLine("Введіть число: ");//1
//string temp = Console.ReadLine();
//int a = int.Parse(temp);
//if (a > 0)
//{
//    Console.WriteLine("Число додатне");
//}
//else if(a < 0)
//{
//    Console.WriteLine("Число від'ємне");
//}
//else
//{
//    Console.WriteLine("Число нуль");
//}

//Console.WriteLine("Введіть число: ");//2
//string temp = Console.ReadLine();
//int a = int.Parse(temp);
////if (a % 2 == 0)
////    Console.WriteLine("Число парне");
////if (!(a % 2 == 0))
////    Console.WriteLine("Число не парне");
//if (a % 2 == 0)
//    Console.WriteLine("Число парне");
//else Console.WriteLine("Число не парне");

//Console.WriteLine("Введіть номер місяця");//3
//string temp = Console.ReadLine();
//int month = int.Parse(temp);
//if (month < 1 || month > 12)
//    Console.WriteLine("Такого місяця не має");
//else
//{
//    if (month == 12 || month == 1 || month == 2)
//        Console.WriteLine("Це зима");
//    else if (month == 3 || month == 4 || month == 5)
//        Console.WriteLine("Це весна");
//    else if (month == 6 || month == 7 || month == 8)
//        Console.WriteLine("Це літо");
//    else Console.WriteLine("Це осінь");
//}

//Console.WriteLine("=== Класний журнал ===");//4
//Console.WriteLine("Введіть ім'я, клас та дві оцінки учня: ");
//string name = Console.ReadLine();
//string temp = Console.ReadLine();
//int clas = int.Parse(temp);
//temp = Console.ReadLine();
//int m1 = int.Parse(temp);
//temp = Console.ReadLine();
//int m2 = int.Parse(temp);
//if (m1 > 12 || m1 < 1)
//    Console.WriteLine("Не коректна оцінка");
//if (m2 > 12 || m2 < 1)
//    Console.WriteLine("Не коректна оцінка");
//double arithmetic_mean = (m1 + m2) / 2.0;
//Console.Write($"Ім'я учня: {name}\nКлас: {clas}\n");
//if (arithmetic_mean >= 10)
//    Console.WriteLine("Середній бал: відмінно!");
//else if (arithmetic_mean >= 7 && arithmetic_mean <= 9.9)
//    Console.WriteLine("Середній бал: добре");
//else if (arithmetic_mean >= 4 && arithmetic_mean <= 6.9)
//    Console.WriteLine("Середній бал: задовільно");
//else Console.WriteLine("Середній бал: треба підтянути");

//Console.WriteLine("=== Лотерея ===");//5
//Console.WriteLine("Введіть своє ім'я, щасливе число та кількість квитків: ");
//int winNumber = 7;
//string name = Console.ReadLine();
//string temp = Console.ReadLine();
//int luckyNumber = int.Parse(temp);
//if (!(luckyNumber >= 1 && luckyNumber <= 49))
//    Console.WriteLine("Ви ввели не коректне щасливе число");
//temp = Console.ReadLine();
//int tikets = int.Parse(temp);
//decimal cost = 20.00m;
//decimal costAll = cost * tikets;
//char ch = '*';
//Console.Write($"***************************\n" +
//              $"*  Гравець: {name}        *\n" +
//              $"*  Ціна: {cost}              *\n" +
//              $"*  Щасливе число: {luckyNumber}       *\n");
//if (luckyNumber == winNumber)
//    Console.WriteLine("Джекпот!");
//else if (!(luckyNumber % 2 == 0))
//    Console.WriteLine("Маленький приз");
//else Console.WriteLine("Не пощастило");
//Console.WriteLine($"{name}, до сплати: {costAll}грн");

//int[] mas = { 5, 8, 12, 3, 20 };//1
//int n = mas.Length;

//for (int i = 0; i < n; i++)
//{
//    Console.Write($"{mas[i]}\t");
//}
//Console.WriteLine(mas[0]);
//Console.WriteLine(mas[4]);

//int n = int.Parse(Console.ReadLine());//2
//int[] arr = new int[n];
//for(int i = 0; i < n; i++)
//{
//    arr[i] = i * i;
//    Console.Write($"{arr[i]}\t");
//}

//double[] arr = new double[6];//3
//Console.WriteLine("Введіть 6 чисел: ");
//for(int i = 0; i < 6; i++)
//{
//    arr[i] = double.Parse(Console.ReadLine());
//}
//double sum = 0;
//for(int i = 0; i < 6; i++)
//{
//    sum += arr[i];
//}
//Console.WriteLine("Сума: "+ sum);
//Console.WriteLine($"Середнє арифметичне: {sum / 6}");
//double max = 0;
//for(int i = 1; i < 6; i++)
//{
//    if (arr[i] > arr[i - 1])
//        max = arr[i];
//    else max = arr[i-1];
//}
//Console.WriteLine($"Найбільше число: {max}");

//Console.WriteLine("=== Класний журнал ===");//4
//Console.WriteLine("Введіть ім'я, клас, кількість оцінок та їх самих: ");
//string name = Console.ReadLine();
//int clas = int.Parse(Console.ReadLine());
//int n = int.Parse(Console.ReadLine());
//int[] marks = new int[n];
//for(int i = 0; i < n; i++)
//{
//    marks[i] = int.Parse(Console.ReadLine());
//}
//for(int i = 0; i < n; i++)
//{
//    if (marks[i] < 1 || marks[i] > 12)
//        Console.WriteLine("Некоректна оцінка!");
//}
//double sum = 0;
//for (int i = 0; i < n; i++)
//{
//    sum += marks[i];
//}
//double arithmetic_mean = sum / n;
//Console.Write($"Ім'я учня: {name}\nКлас: {clas}\n");
//if (arithmetic_mean >= 10)
//    Console.WriteLine("Середній бал: відмінно!");
//else if (arithmetic_mean >= 7 && arithmetic_mean <= 9.9)
//    Console.WriteLine("Середній бал: добре");
//else if (arithmetic_mean >= 4 && arithmetic_mean <= 6.9)
//    Console.WriteLine("Середній бал: задовільно");
//else Console.WriteLine("Середній бал: треба підтянути");

//Console.WriteLine("=== Лотерея ===");//5
//Console.WriteLine("Введіть своє ім'я, щасливе число: ");
//int winNumber = 7;
//int[] ticket = new int[6];
//int[] draw = { 5, 12, 23, 31, 40, 47 };
//string name = Console.ReadLine();
//string temp = Console.ReadLine();
//int luckyNumber = int.Parse(temp);
//Console.WriteLine("Введіть 6 чисел: ");
//for(int i = 0; i < 6; i++)
//{
//    ticket[i] = int.Parse(Console.ReadLine());
//}
//int n = 0;
//for(int i = 0; i < 6; i++)
//{
//    if (ticket[i] == draw[i])
//        n++;
//}
//if (!(luckyNumber >= 1 && luckyNumber <= 49))
//    Console.WriteLine("Ви ввели не коректне щасливе число");
//Console.WriteLine("Введіть кількість квитків: ");
//temp = Console.ReadLine();
//int tikets = int.Parse(temp);
//decimal cost = 20.00m;
//decimal costAll = cost * tikets;
//char ch = '*';
//Console.Write($"***************************\n" +
//              $"*  Гравець: {name}        *\n" +
//              $"*  Ціна: {cost}              *\n" +
//              $"*  Щасливе число: {luckyNumber}       *\n");
//if (luckyNumber == winNumber)
//    Console.WriteLine("Джекпот!");
//else if (!(luckyNumber % 2 == 0))
//    Console.WriteLine("Маленький приз");
//else Console.WriteLine("Не пощастило");
//Console.WriteLine($"{name}, до сплати: {costAll}грн");
//Console.WriteLine($"Збігів: {n}");

//Random r = new Random();//1
//int[] myArray = new int[10];

//for(int i = 0; i < myArray.Length; i++)
//{
//    myArray[i] = r.Next(1, 7);
//    Console.Write($"{myArray[i]}\t");
//}

//Random r = new Random();//2
//int[] temperatura = new int[7];
//for(int i = 0; i < temperatura.Length; i++)
//{
//    temperatura[i] = r.Next(-10, 26);
//    Console.Write($"{temperatura[i]}\t");
//}
//Console.WriteLine();
//double[] x = new double[5];
//for(int i = 0; i < x.Length; i++)
//{
//    x[i] = r.NextDouble();
//    Console.WriteLine($"{x[i]}");
//}    

//for (int i = 0; i < 5; i++)//3
//{
//    Console.WriteLine("ПІБ = " + myFaker.Name.FullName());
//    Console.WriteLine("Телефон = " + myFaker.Phone.PhoneNumber());
//    Console.WriteLine("Місто = " + myFaker.Address.City());
//}

//Random r = new Random();//4
//Console.WriteLine("=== Класний журнал ===");
//Console.WriteLine("Виберіть: 1 - ввести вручну, 2 - згенерувати: ");
//int or = int.Parse(Console.ReadLine());
//if (or == 2)
//{
//    Console.Write($"Ім'я учня: {myFaker.Name.FullName()}\nКлас: {r.Next(1, 13)}\n");
//    int[] marks1 = new int[r.Next(1, 16)];
//    for (int i = 0; i < marks1.Length; i++)
//    {
//        marks1[i] = r.Next(1, 13);
//        Console.WriteLine(marks1[i]);
//    }
//    int sum1 = 0;
//    for(int i = 0; i < marks1.Length; i++)
//    {
//        sum1 += marks1[i];
//    }
//    double am = sum1 / marks1.Length;
//    if (am >= 10)
//        Console.WriteLine("Середній бал: відмінно!");
//    else if (am >= 7 && am <= 9.9)
//        Console.WriteLine("Середній бал: добре");
//    else if (am >= 4 && am <= 6.9)
//        Console.WriteLine("Середній бал: задовільно");
//    else Console.WriteLine("Середній бал: треба підтянути");
//}
//else
//{
//    Console.WriteLine("Введіть ім'я, клас, кількість оцінок та їх самих: ");
//    string name = Console.ReadLine();
//    int clas = int.Parse(Console.ReadLine());
//    int n = int.Parse(Console.ReadLine());
//    int[] marks = new int[n];
//    for (int i = 0; i < n; i++)
//    {
//        marks[i] = int.Parse(Console.ReadLine());
//    }
//    for (int i = 0; i < n; i++)
//    {
//        if (marks[i] < 1 || marks[i] > 12)
//            Console.WriteLine("Некоректна оцінка!");
//    }
//    double sum = 0;
//    for (int i = 0; i < n; i++)
//    {
//        sum += marks[i];
//    }
//    double arithmetic_mean = sum / n;
//    Console.Write($"Ім'я учня: {name}\nКлас: {clas}\n");
//    for (int i = 0; i < marks.Length; i++)
//    {
//        Console.WriteLine(marks[i]);
//    }
//    if (arithmetic_mean >= 10)
//        Console.WriteLine("Середній бал: відмінно!");
//    else if (arithmetic_mean >= 7 && arithmetic_mean <= 9.9)
//        Console.WriteLine("Середній бал: добре");
//    else if (arithmetic_mean >= 4 && arithmetic_mean <= 6.9)
//        Console.WriteLine("Середній бал: задовільно");
//    else Console.WriteLine("Середній бал: треба підтянути");
//}

//Random r = new Random();
//Console.WriteLine("=== Лотерея ===");//5
//Console.WriteLine("Введіть щасливе число: ");
//int winNumber = 7;
//int[] ticket = new int[6];
//for(int i = 0; i < 6; i++)
//{
//    ticket[i] = r.Next(1, 50);
//}
//int[] draw = new int[6];
//for(int i = 0; i < 6; i++)
//{
//    draw[i] = r.Next(1, 50);
//}
//int luckyNumber = int.Parse(Console.ReadLine());
////Console.WriteLine("Введіть 6 чисел: ");
////for (int i = 0; i < 6; i++)
////{
////    ticket[i] = int.Parse(Console.ReadLine());
////}
//int n = 0;
//for (int i = 0; i < 6; i++)
//{
//    if (ticket[i] == draw[i])
//        n++;
//}
//if (!(luckyNumber >= 1 && luckyNumber <= 49))
//    Console.WriteLine("Ви ввели не коректне щасливе число");
//Console.WriteLine("Введіть кількість квитків: ");
//string name = myFaker.Name.FirstName();
//int tikets = int.Parse(Console.ReadLine());
//decimal cost = 20.00m;
//decimal costAll = cost * tikets;
//char ch = '*';
//Console.Write($"***************************\n" +
//              $"*  Гравець: {name}*\n" +
//              $"*  Телефон: {myFaker.Phone.PhoneNumber()} *\n" +
//              $"*  Місто: {myFaker.Address.City()}*\n" +
//              $"*  Ціна: {cost}              *\n" +
//              $"*  Щасливе число: {luckyNumber}       *\n");
//if (luckyNumber == winNumber)
//    Console.WriteLine("Джекпот!");
//else if (!(luckyNumber % 2 == 0))
//    Console.WriteLine("Маленький приз");
//else Console.WriteLine("Не пощастило");
//Console.WriteLine($"{name}, до сплати: {costAll}грн");
//Console.WriteLine($"Збігів: {n}");

//string[] arr = { "Оля", "Ігор", "Марія" };//1
//foreach(var name in arr)
//{
//    Console.WriteLine($"Привіт, {name}!");
//}

//Random r = new Random();//2
//int[] arr = new int[8];
//for(int i = 0; i < 8; i++)
//{
//    arr[i] = r.Next(1, 51);
//}
//int sum = 0;
//foreach(var x in arr)
//    sum += x;
//int n = 0;
//foreach(var x in arr)
//{
//    if (x % 2 == 0)
//        n++;
//}
//int max = arr[0];
//foreach (var x in arr)
//    if (x > max)
//        max = x;

//var a = 10; // int //3
//var b = 3.5; // doublr
//var c = "Привіт"; // string
//var d = 'x'; // char

Random r = new Random();//4
Console.WriteLine("=== Класний журнал ===");

string[] names = new string[10];
double[] averages = new double[10];
for (int i = 0; i < 10; i++)
{
    names[i] = myFaker.Name.FullName();
}
for (int i = 0; i < 10; i++)
{
    averages[i] = (r.Next(1, 13) + r.Next(1, 13) + r.Next(1, 13) + r.Next(1, 13) + r.Next(1, 13)) / 5.0;
}
int index = 0;
foreach(var name in names)
{
    Console.WriteLine($"{name}: {averages[index]:F2}");
    index++;
}

int excellentCount = 0;
int bestIndex = 0;

for (int i = 0; i < averages.Length; i++)
{
    {
    if (averages[i] >= 10)
        excellentCount++;
    }

    if (averages[i] > averages[bestIndex])
    {
        bestIndex = i;
    }
}

Console.WriteLine($"\nКількість відмінників: {excellentCount}");
Console.WriteLine($"Найкращий учень: {names[bestIndex]} — {averages[bestIndex]:F2}");