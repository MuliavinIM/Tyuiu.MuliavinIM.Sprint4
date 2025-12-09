using Tyuiu.MuliavinIM.Sprint4.Task0.V29.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                   *");
        Console.WriteLine("* Тема: Обработка структурных типов                                                           *");
        Console.WriteLine("* Задание #0                                                                                  *");
        Console.WriteLine("* Вариант #29                                                                                 *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Подсчитать сумму нечетных элементов массива                                                 *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");


        int[] nums = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };

        Console.WriteLine("Исходный массив: ");

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            Console.WriteLine(nums[i] + "\t");
        }




        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        int res = ds.GetSumOddArrEl(nums);

        Console.WriteLine("Сумма нечётных элементов массива: " + res);

        Console.ReadKey();

    }
}