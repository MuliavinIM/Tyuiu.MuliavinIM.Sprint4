using Tyuiu.MuliavinIM.Sprint4.Task6.V16.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Класс Array                                                       *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан строковый массив данных, используя класс Array, выведите элементы м *");
Console.WriteLine("* ассива, длина которых равна 7 символам.                                 *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

var array = new string[] { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };

Console.WriteLine("Исходный массив:");

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Элементы, длинна которых = 7:");

string[] words = ds.Calculate(array);

foreach (string word in words)
{
    Console.WriteLine(word);
}
Console.ReadKey();