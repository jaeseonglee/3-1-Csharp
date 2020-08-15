/*	실습 3번
	작성일 : 2020.05.04 ~ 05
    작성자 : 20165153 이재성
	프로그램 설명 : 다음과 같이 실행되는 스레드 프로그램을 작성하시오
            Apple 스레드는 문자 A ~ J 까지 출력
            Orange 스레드는 숫자 10~20까지 출력
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;     // 스레드 사용 위해 using System.Threading

namespace Number3
{
    class Program
    {
        static void ThreadAlpha()       // A부터 J까지 출력하는 ThreadAlpha
        {  
            for (int i = 65; i < 75; i++)   // 반복문을 통해 출력문 출력
            {
                Console.WriteLine($"Apple is activated => {(char)i}");
                Thread.Sleep(1000);
            }
        }
        static void ThreadNum()     // 10부터 20까지 출력하는 ThreadNum
        {  
            for (int i = 10; i <= 20; i++)    // 반복문을 통해 출력문 출력
            {
                Console.WriteLine($"Orange is activated => {i}");
                Thread.Sleep(1000);
            }

        }
            static void Main(string[] args)
        {
            ThreadStart alpha = new ThreadStart(ThreadAlpha); // 각각의 스레드를 ThreadStart 델리게이트에 연결
            ThreadStart num = new ThreadStart(ThreadNum);
            Thread apple = new Thread(alpha);                 // 스레드 객체 생성하고
            Thread orange = new Thread(num);  
            apple.Start();          // Start
            orange.Start();                                        
        }
    }
}
