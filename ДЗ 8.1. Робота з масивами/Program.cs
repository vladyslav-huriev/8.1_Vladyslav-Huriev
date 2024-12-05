/*int[] numbers1 = new int[5];
int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine(numbers[0]); // the result is 1 - 0 = 1
Console.WriteLine(numbers[4]); // the result is 5 - because the number 4 is number 5 starting from 0
numbers[4] = 100;*/

// 8.1.1 + 8.1.2 - Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10, використовуючи клас Random Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!)
// +Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.


/*Random qwer = new Random();
int[] massive = new int[10];
for (int i = 0; i < massive.Length; i++)
{
    massive[i] = qwer.Next(-10, 11);
}
Console.WriteLine("Even elements: ");
for (int i = 0; i < massive.Length; i += 2)
{
    Console.WriteLine($"Index {i}: {massive[i]}");
}
int sum = 0;
foreach (int value in massive)
{
    sum += value;
}
Console.WriteLine($"Summ of even elements: {sum}");
if (sum >= 0)
{
    Console.WriteLine("Sum is NOT negative number");
}
else
{
    Console.WriteLine("Summ is negative number");
}*/

// 8.1.3 - Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення (у першому рядку мають бути записані добутки кожного з чисел від 1 до 9 на 1, у другому – на 2, ..., в останньому – на 9). Тобто в 1 строчці будуть значення від 1 до 9, а у другому 2,4,6,....,18 і т.д.

/*int[,] multTable = new int[9, 9];
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        multTable[i, j] = (i + 1) * (j + 1);
    }
}
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write(multTable[i, j] + "\t");
    }
    Console.WriteLine();
}*/

// 8.1.4 - Створити двовимірний масив 5х5. Заповнити його будь-якими числами. Визначити та вивести на екран: а) максимальний елемент масиву; б) мінімальний елемент масиву; в) координати мінімального елемента масиву. г) координати максимального елемента масиву.

/* int[,] massive = new int[5, 5];
Random qwer = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        massive[i, j] = qwer.Next(-100, 100);
    }
}
int maxValue = massive[0, 0];
int minValue = massive[0, 0];
int maxRow = 0, maxCol = 0;
int minRow = 0, minCol = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (massive[i, j] > maxValue)
        {
            maxValue = massive[i, j];
            maxRow = i;
            maxCol = j;
        }
        if (massive[i, j] < minValue)
        {
            minValue = massive[i, j];
            minRow = i;
            minCol = j;
        }
    }
}
Console.WriteLine("Massive: ");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(massive[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine($"Maximum value: {maxValue} at coordinates ({maxRow}, {maxCol})");
Console.WriteLine($"Minimum value: {minValue} at coordinates ({minRow}, {minCol})"); */

// 8.1.5 - За допомогою enum створити програму, що буде запитувати у користувача кількість днів, а потім рахувати який буде день через введену кількість, якщо рахувати від понеділка і виводити результат. Наприклад: 
// Приклад 1: Вхідний параметр: 13 Очікуваний вивід: Sunday
// Приклад 2: Вхідний параметр: 3 Очікуваний вивід: Thursday

Console.WriteLine("Enter number of days: ");
int specialDay = int.Parse(Console.ReadLine());
daysoftheweek startDay = daysoftheweek.Monday;
daysoftheweek resultDay = (daysoftheweek)((int)startDay + specialDay % 7);
Console.WriteLine($"The day after day number {specialDay} will be: {resultDay}");
enum daysoftheweek
{
    Monday,   
    Tuesday,  
    Wednesday, 
    Thursday,  
    Friday,   
    Saturday,  
    Sunday    
}