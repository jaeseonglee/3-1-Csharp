/*	실습 3번
	작성일 : 2020.04. 16
    작성자 : 20165153 이재성
	프로그램 설명 : 사각형과 원에 대한 클래스를 정의하고 넓이,둘레,그림을 그리는 프로그램
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number3
{
    interface Figure        // 도형의 정보를 가진 인터페이스
    {
        void Area(); //넓이를 구하는 메소드
        void Girth(); //둘레를 구하는 메소드
        void Draw(); //도형을 그리는 메소드
    }
  
    class Rectangle : Figure        // 인터페이스를 구현하는 클래스 Rectangle
    {
        int row;    // 가로
        int col;    // 세로
        public Rectangle(int x, int y)  // 가로와 세로 길이를 입력받는 생성자
        {
            row = x;
            col = y;
        }
        void Figure.Area()              // 넓이 출력
        {
            Console.WriteLine($"Rectangle Area : {row * col}");
        }

        void Figure.Girth()             // 둘레 출력
        {
            Console.WriteLine($"Rectangle Girth : { (row + col) * 2}");
        }

        void Figure.Draw()              // 그리기 출력 
        {
            Console.WriteLine("사각형을 그립니다.");
            /*
            for(int i = 0; i < row; i++)        // 사각형을 그리는 중첩 반복문
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            */
        }
    }

    class Circle : Figure           // 인터페이스르 구현하기 위한 Circle 클래스
    {
        static readonly double pi = 3.14;   // 읽기 전용 상수 pi
        int radius;

        public Circle(int r)            // 반지름을 입력받는 생성자
        {
            radius = r;
        }

        void Figure.Area()              // 원의 넓이 출력
        {
            Console.WriteLine($"Circle Area : {radius * radius * pi}");
        }

        void Figure.Girth()             // 원의 둘레 출력
        {
            Console.WriteLine($"Circle Girth : {2 * radius * pi}");
        }

        void Figure.Draw()              // 원을 그리는 것을 출력
        {
            Console.WriteLine("\n원을 그립니다.");
            // 원을 그리고 싶었으나 구현 실패
        }
    }

    class Program
    {
        static void Main(string[] args)     // Main
        {   
            Rectangle r = new Rectangle(5, 10); // 사각형 
            ((Figure)r).Draw();
            ((Figure)r).Area();
            ((Figure)r).Girth();
            
            Circle c = new Circle(5);       // 원
            ((Figure)c).Draw();
            ((Figure)c).Area();
            ((Figure)c).Girth();
            
        }
    }
}
