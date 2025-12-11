using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MuliavinIM.Sprint4.Task7.V1.Lib
{
    public class DataService : ISprint4Task7V1
    {
        public int Calculate(int n, int m, string value)
        {
            value = "135792468";

            int count = 0;

            for (int i = 0; i < value.Length; i++)
                if ((value[i] - '0') % 2 == 0)
                    count++;

            return count;
        }
    }
}
