/*	실습 2번
	작성일 : 2020.03.30
    작성자 : 20165153 이재성
	프로그램 설명: 1부터 500 사이의 완전수를 출력하는 프로그램.
                완전수란 자기자신을 제외한 약수의 합이 자기자신과 같은 수이다(예:6=1+2+3)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2
{
    class Program
    {
        static void Main(string[] args)     // Main
        {
            int num = 1;                    // int형 변수 num 선언 및 초기화           
            int cnt = 1;                    // 완전수의 개수를 저장할 cnt 선언 및 초기화
            Console.WriteLine("1부터 500 사이의 완전수를 출력합니다");    // 1부터 500사이의 완전수를 출력한다고 출력

            while( num < 500) {             // num이 500보다 커질때까지 반복
                int sum = 0;                // 약수들의 합을 저장할 sum 선언 및 0으로 초기화
                num++;                      // 매 반복마다 num값 증가

                for(int i = 1; i < num; i++ ) { // for문을 통해 약수들의 합 계산
                    if(num % i == 0)        // num 약수라면 
                        sum += i;           // sum에 값을 더해준다    
                }

                if(num == sum)              // for문을 통해 얻은 sum 값이 num과 같다면 
                    Console.WriteLine("{0, 9})  {1} ", cnt++ , num);    // 완전수이므로 출력, cnt증가
            }

        }
    }
}
