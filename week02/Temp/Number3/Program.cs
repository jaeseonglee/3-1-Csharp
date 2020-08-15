/*	실습 3번
	작성일 : 2020.03.30
    작성자 : 20165153 이재성
	프로그램 설명: 암스트롱수란 3개의 숫자로 구성되며 각 자릿수에 있는 숫자의 세제곱의 합이 자신과 같은 수이다.
                100부터 500사이의 암스트롱수를 구하는 프로그램을 작성하시오.
                XYZ = X^3 + Y^3 + Z^3
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number3
{
    class Program
    {
        static void Main(string[] args)                         // Main
        {
            int num = 100;                  // int형 변수 num 선언 및 100으로 초기화

            while (num < 500)               // num이 500보다 커질때까지 반복
            {
                int i = num / 100 ;         // 현재 num의 백의 자리를 i에 저장
                int j = (num % 100) / 10;   // 현재 num의 십의 자리를 i에 저장
                int n = num % 100 % 10;     // 현재 num의 일의 자리를 i에 저장

                if (num == (i * i * i) + (j * j * j) + (n * n * n) ) // 암스트롱 수의 조건에 해당한다면
                    Console.WriteLine(" {0}", num);     // 현재 num 출력

                num++;      // 매 반복이 끝날때마다 num값 1 증가
            }
        }
    }
}
