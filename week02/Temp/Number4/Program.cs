/*	실습 4번
	작성일 : 2020.03.30
    작성자 : 20165153 이재성
	프로그램 설명 : 이차원 배열을 사용하여 제시된 결과처럼 ‘ㄹ’자로 채우는 프로그램을 작성하시오. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number4
{
    class Program
    {
        static void Main(string[] args)                 // Main
        {
            int row = 0;                        // 행 변수
            int col = 0;                        // 열 변수
            // Console.Read로 입력받을경우 char형으로 문자에 맞는 ASCII 코드 값으로 저장됨. - 20.03.30

            Console.WriteLine("행 크기를 입력하세요");   // 행 크기를 입력받는다.
            row = int.Parse(Console.ReadLine());       // int.Parse를 통해 int형으로 변환하여 저장
          
            Console.WriteLine("열 크기를 입력하세요");   // 열 크기를 입력받는다.
            col = int.Parse(Console.ReadLine());       // int.Parse를 통해 int형으로 변환하여 저장

            for (int i = 0; i < row; i++) {             // 중첩 반복문을 통해 결과 출력
                if (i % 2 == 0 ) {                      // 현재 행이 홀수번째 행이면
                    for (int j = 1; j <= col; j++)      // 오름 차순으로 출력
                        Console.Write(" {0,2}", (i * col) + j );
                } else {                                // 현재 행이 짝수번째 행이면
                    for (int j = col; j > 0; j--)       // 내림 차순으로 출력
                        Console.Write(" {0,2}", (i * col) + j);
                }

                Console.WriteLine();                    // 행이 바뀔 때마다 줄바꿈
            }
        }
    }
}
