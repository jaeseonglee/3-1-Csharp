/*	실습 1번
	작성일 : 2020.04.14 ~ 15
    작성자 : 20165153 이재성
	프로그램 설명 : 1에서 20사이의 난수를 5개 발생시켜 한 자리수 이면 곱을 구하고,
        두 자리 수이면 한자리씩 분리하여 합과 차를 구하는 프로그램 (델리게이트를 통하여 메소드 호출)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1
{
    // 정수형 매개변수 1개인 메소드를 호출할 델리게이트 선언 – 본인 작성
    delegate void NumberOne(int num);
    // 정수형 매개변수 2개인 메소드를 호출할 델리게이트 선언 – 본인 작성
    delegate void NumberTwo(int num1, int num2);

    class MyClass
    {
        public void MUL(int x)  // X*X 계산 결과 출력하는 함수 – 본인 작성
        {
            Console.WriteLine($"MUL={x * x}");  // 한자리 수의 경우 제곱수인 x*x 출력 
        }

        public void ADD(int x, int y)  // x+y 계산 결과 출력하는 함수 – 본인작성
        {
            Console.WriteLine($"ADD={x + y}");  // x + y 값을 출력
            SUB(x, y);          // static 함수를 호출해서 SUB 값도 출력해준다
        }

        public static void SUB(int x, int y) //x-y 계산 결과 출력하는 함수 – 본인작성
        {
            Console.WriteLine($"SUB={x - y}");  // x - y 값을 출력
        }
    }

    class MyClassTest
    {
        static void Main(string[] args)     // Main
        {
            //델리게이트를 통하여 메소드 호출(5회 반복) – 본인작성
            MyClass obj = new MyClass();    // 델리게이트할 메소드를 갖는 객체 생성
            Random r = new Random();        // 랜덤값을 위한 객체

            NumberOne numOne = new NumberOne(obj.MUL); // 델리게이트 선언, 생성 한 자리 수의 경우 메소드 연결
            NumberTwo numTwo = new NumberTwo(obj.ADD); // 델리게이트 선언, 생성 두 자리 수의 경우 메소드 연결

            for (int i = 0; i < 5; i++)        // 5회 반복하는 반복문
            {
                int num = r.Next(1, 20);        // 1부터 20까지의 난수를 num에 저장
                Console.WriteLine($"random number : {num}"); // num 값 출력
                if (num < 10)       // 자리수에 따라
                {   
                    numOne(num);    // 곱 출력
                }
                else                // 두 자리 수 라면
                {
                    numTwo(num / 10, num % 10); // 합과 차를 출력한다.
                }
            }
        }
    }
}