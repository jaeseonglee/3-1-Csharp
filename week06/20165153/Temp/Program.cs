using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    //internal delegate bool judgement(int value);
    class LamdaExam
    {
        /*
        public bool IsEven(int n)
        {
            return n % 2 == 0;
        }
        */
        
        public int Count(int[] num, Func<int, bool> func1 )  {
            int count = 0;

            foreach (var n in num) { 
                if (func1(n) == true)
                    count++;
            }
            return count;
        }

    public void Do()
    {
        var array = new int[] { 5, 2, 6, 3, 12, 8, 0, 1, 10, 4 }; 
        var cnt = Count(array, x => x % 2 == 0); 
        Console.WriteLine($"cnt = {cnt}");
    }

    }

    class Program
    {
        static void Main(string[] args)
        {
            LamdaExam lamda = new LamdaExam();
            lamda.Do();
        }
    }
}
