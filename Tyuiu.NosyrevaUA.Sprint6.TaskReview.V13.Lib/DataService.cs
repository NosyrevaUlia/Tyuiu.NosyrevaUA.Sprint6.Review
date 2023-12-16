using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.NosyrevaUA.Sprint6.TaskReview.V13.Lib
{
    public class DataService 
    {
        public int  GetMatrix(int[,] array,int C, int K, int L)
        {
            int N = array.GetUpperBound(0) + 1;
            int M = array.Length / N;

            int indexOsobyi = 3;                        //буду прибавлять к индексу по 4
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < M; j++)
                {
                    if(j == indexOsobyi)
                    {
                        array[i, j] = array[i, j - 3] - array[i, j - 2] - array[i, j - 1];
                        indexOsobyi += 4;
                    }
                }
                indexOsobyi = 3;
            }
           

            int result = 0;
            for(int i = K; i <= L; i++)
            {
                if (i%2 == 0)
                {
                    result += array[i, C ];    
                }
            }

            return result;
        }
    }
}
