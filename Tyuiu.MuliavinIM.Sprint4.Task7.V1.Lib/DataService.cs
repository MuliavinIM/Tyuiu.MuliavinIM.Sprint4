using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MuliavinIM.Sprint4.Task7.V1.Lib
{
    public class DataService : ISprint4Task7V1
    {
        public int Calculate(int n, int m, string value)
        {
            int res = 0;
            foreach (char element in value)
            {
                if ((int)Char.GetNumericValue(element) % 2 == 0)
                {
                    res++;
                }
            }
            return res;
        }
    }
}
