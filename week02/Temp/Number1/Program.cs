/*	실습 1번
	작성일 : 2020.03.30
    작성자 : 20165153 이재성
	프로그램 설명: 일주일의 각 요일을 열거형으로 정의한 프로그램
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1
{
    class Program
    {   
        enum Week { Sun = 0, Mon, Tue, Wed, Thu, Fri, Sat}; // 요일들을 열거형으로 정의
        static void Main(string[] args)             // Main
        {
            Week day = Week.Thu;                      // day에 열거형 값 Thu로 초기화
            
            Console.WriteLine("오늘은 {0} 일 입니다", day);      // day에 저장된 값 출력
            Console.WriteLine("어제는 {0} 일 이었고", --day);    // 감소 연산자를 통해 원소 이동, Wed 출력
            day++;                                              // 증가 연산자를 통해 원소 이동
            Console.WriteLine("내일은 {0} 일 입니다", ++day);    // 증가 연산자를 통해 원소 이동, Fri 출력
        }
    }
}
