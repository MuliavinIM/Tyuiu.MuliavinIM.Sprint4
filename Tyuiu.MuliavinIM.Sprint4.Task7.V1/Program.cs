using Tyuiu.MuliavinIM.Sprint4.Task7.V1.Lib;

namespace Tyuiu.MuliavinIM.Sprint4.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Мулявин И.М. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Мулявин Иван Михайлович | ИСТНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"135792468\". Преобразуйте её в матрицу *");
            Console.WriteLine("* 3 на 3 и подсчитайте количество чётных чисел.                           *");
            Console.WriteLine("***************************************************************************");

            int rows = 3, columns = 3;
            int[,] mtrx = new int[rows, columns];

            string value = "135792468";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * columns + j, 1));
                }
            }

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Матрица:{ ");
            for (int i = 0; i < rows; i++)
            {
                if (i != 0) Console.Write("\t ");
                Console.Write("{");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(mtrx[i, j]);
                    if (j < columns - 1) Console.Write(", ");
                }
                Console.Write("}");
                if (i < rows - 1) Console.WriteLine(",");
            }
            Console.WriteLine(" }");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = dataService.Calculate(rows, columns, value);

            Console.WriteLine("Количество чётных чисел: " + res);

            Console.ReadKey();
        }
    }
}
