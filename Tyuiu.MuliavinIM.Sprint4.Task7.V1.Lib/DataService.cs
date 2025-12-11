using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MuliavinIM.Sprint4.Task7.V1.Lib
{
    public class DataService : ISprint4Task7V1
    {
        public int Calculate(int n, int m, string value)
        {
            string s = "135792468";  
            int even = 0;

            for (int i = 0; i < s.Length; i++)
                if ((s[i] - '0') % 2 == 0)
                    even++;

            return even;
        }
    }
}
