

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;  //Thread 클래스의 Sleep() 사용을 위해 필요

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 3);
                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else if (x % 3 == 2)
                    Console.WriteLine("^_@");
                Thread.Sleep(1000);  //Sleep() : 괄호안의 값만큼 실행 지연, 밀리세컨드 단위
                x++;
            }



        }
    }
}
