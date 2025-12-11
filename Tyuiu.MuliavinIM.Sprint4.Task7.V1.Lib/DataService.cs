using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MuliavinIM.Sprint4.Task7.V1.Lib
{
    public class DataService : ISprint4Task7V1
    {
        public int Calculate(int n, int m, string value)
        {
            string data = "135792468";

            int[,] matrix = new int[3, 3];
            int index = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = data[index] - '0';
                    index++;
                }
            }

            int countEven = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                        countEven++;
                }
            }

            return countEven;
        }
    }
}
