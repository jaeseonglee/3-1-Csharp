/*	실습 2번
	작성일 : 2020.04. 15
    작성자 : 20165153 이재성
	프로그램 설명 : 연산자 재정의를 통해 날짜차이를 계산하는 프로그램
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2
{
    class Date
    {
        private int day, month, year;
        public Date(int mm, int dd, int yy)
        {     // 생성자
            day = dd;
            month = mm;
            year = yy;
        }
        public static Date operator +(Date d, int n)
        {// 날짜에 대한 + 연산 정의
            int num = DateTime.DaysInMonth(d.year, d.month); // 객체가 가진 이번달의 날짜를 계산
            int result = d.day + n;      // 객체가 가진 날짜에 몇일을 더하는지 계산

            while(true)             // 무한 반복문
            {
                if (result < num)   // 날짜를 합친 값보다 이번달의 날짜가 더 크면 
                {
                    d.day = result;  // day를 result로 초기화
                    break;           // 반복 탈출
                }
                else                // 합친 날짜가 더 크다면
                {
                    result -= num;    // 합친 날짜의 값에서 이번달의 날짜 값을 빼준다
                }
                    
                if (d.month + 1 > 12) // 이번달이 12월 달이라면
                {
                    d.year++;       // 연도를 올려주고
                    d.month = 0;    // 아랫줄의 num값 초기화를 위해 0으로 저장
                } 

                // 위에서 else를 통해 조건문을 빠져나왔다면 다음 달의 날짜를 계산한다.
                num = DateTime.DaysInMonth(d.year, ++d.month);
            }

            return d;        // 객체 d 반환
        }

        public static Date operator -(Date d, int n)
        {   // 날짜에 대한 - 연산 정의
            int num = 0;            // int형 변수 num 선언 및 초기화
            int x = d.day - n;      // 객체가 가진 날짜에 몇일을 빼는지 계산

            while (true)            // 무한 반복문
            {
                if (d.month - 1 < 1)// 이번 달이 1월이라면
                {
                    d.year--;       // 연도를 내려주고
                    d.month = 13;   // 아랫줄의 num값 초기화를 위해 13 저장
                }
                
                num = DateTime.DaysInMonth(d.year, --d.month);  // 객체가 가진 달의 이전달 날짜 값을 계산

                if (x > 0)      // 첫번째 경우 x(날짜의 차)가 양수라면
                {
                    d.day -= n; // 그대로 날짜의 차를 계산하고 저장
                }
                else if (Math.Abs(x) < num) // 두번째 경우 x가 음수이고 그 절댓값이 num보다 작을 경우
                {
                    d.day = num - Math.Abs(x); //이전 달의 날짜 값에서 x만큼 빼준 값을 저장
                    break;                     // 반복 탈출
                }
                else                        // 차의 절댓값이 이전달의 날짜값보다 크다면
                {       
                    x += num;               // x에 날짜 값을 더해준다.
                }
            }

            return d; // 객체 d 반환
        }
        override public string ToString()
        {  // mm/dd/yy
            return string.Format("{0,2}/{1,2}/{2,2}", month, day, year);
        }
    }

    class Program
    {
        static void Main(string[] args)     // Main
        {
            Date d1 = new Date(4, 15, 2020);  //날짜는 자유롭게 본인이 정할 것
            Date d2 = new Date(11, 28, 2020);

            Console.WriteLine($"d1 = {d1}");
            Console.WriteLine($"d2 = {d2}");

            d1 = d1 - 50;
            Console.WriteLine("d1-50 : " + d1);

            d2 = d2 + 50;
            Console.WriteLine("d2+50 : " + d2);
            
        }

    }
}
