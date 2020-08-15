/*	실습 5번
	작성일 : 2020.03.30 ~ 03.31
    작성자 : 20165153 이재성
	프로그램 설명 : 전기 포트를 사용하여 물을 가열하는 프로그램을 작성하시오.
                단, 일정한 시간 간격을 두고 ‘@’를 출력하도록 한다
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;  //Thread 클래스의 Sleep() 사용을 위해 필요


namespace Number5
{
    class Program
    {
        static void Main(string[] args)                         // Main
        {
            Console.WriteLine("1: 보온(60분)\t2: 차(5분)\t3:중탕(10분)\t4:급속가열(30분)"); // 번호에 따른 기능 출력
            Console.Write("선택 >>>  ");                        // 번호를 입력받음
            int num = int.Parse(Console.ReadLine());            // 입력받은 문자를 정수형으로 저장

            switch (num) {                          // switch 문, @ 5분단위로 출력하며 1초(1000밀리세컨드)동안 시간 지연
                case 1:                             
                    for(int i = 0; i < 12; i++) {   // 5분단위로 @를 출력하기위해 12번 반복
                        if ( i == 6) Console.WriteLine(); // 6번(30분) 지연되면 줄바꿈
                        Console.Write("@");
                        Thread.Sleep(1000);  //Sleep() : 괄호안의 값만큼 실행 지연, 밀리세컨드 단위
                    }
                    Console.WriteLine("\n 60(분) 가열 종료");
                    break;

                case 2:
                    Console.Write("@");             // 5분이기때문에 한번만 출력
                    Thread.Sleep(1000);  
                    Console.WriteLine("\n 5(분) 가열 종료");
                    break;

                case 3:
                    for (int i = 0; i < 2; i++) {   // 10분이기 때문에 2번 반복
                        Console.Write("@");
                        Thread.Sleep(1000);  //Sleep() : 괄호안의 값만큼 실행 지연, 밀리세컨드 단위
                    }
                    Console.WriteLine("\n 10(분) 가열 종료");
                    break;

                case 4:
                    for (int i = 0; i < 6; i++) {   // 30분이기 때문에 6번 반복
                        Console.Write("@");
                        Thread.Sleep(1000);  //Sleep() : 괄호안의 값만큼 실행 지연, 밀리세컨드 단위
                    }
                    Console.WriteLine("\n 30(분) 가열 종료");
                    break;

                default:                        // 다른 숫자가 입력되면 프로그램 종료
                    Console.WriteLine(" 입력 오류!\n 프로그램을 종료합니다.\n"); break;
            }
        }
    }
}
