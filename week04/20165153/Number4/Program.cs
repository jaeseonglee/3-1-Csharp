/*	실습 4번
	작성일 : 2020.04.16 ~ 17
    작성자 : 20165153 이재성
	프로그램 설명 : 상속과 다형성을 활용하여 사람에 대한 정보와 그 정보를 기반으로
        공적 마스크 구매 가능 여부를 출력하는 프로그램
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number4
{
    class Person                // Person 클래스
    {
        //필드 구성 : 이름, 생년월일, 나이
        string name;
        int year, month, day;
        int age;

        public Person()         // 생성자
        {
            Console.Write("이름 => ");        // 이름, 생년월일을 입력받는다
            name = Console.ReadLine();
            Console.WriteLine("생년월일");
            year = int.Parse(Console.ReadLine());
            month = int.Parse(Console.ReadLine());
            day = int.Parse(Console.ReadLine());
            age = DateTime.Today.Year - year + 1;       // 입력받은 생년월일로 나이 계산
        }

        virtual public void display()   // 이름과 나이, 생년월일 출력
        {
            Console.WriteLine("================================");
            Console.WriteLine($"이름 : {name}  나이 : {age}");
            Console.WriteLine($"생년월일 : {year}년 {month}월 {day}일");
        }

        public void BuyPossible()           // 구매가능 여부를 확인하는 BuyPossible 메소드
        {
            var today = DateTime.Today;  //현재 날짜 정보를 today에 저장
            int b = year % 10;          // 태어난 연도의 한자리수만 저장
            if (b == 0) b = 5;          // 0이라면 5로 초기화해준다
            if (b > 6) b -= 5;          // 5보다 크다면 5씩 빼준다

            Console.WriteLine(">>> 공적 마스크 구매 가능 여부 <<<");
            if ((int)today.DayOfWeek == 0 || (int)today.DayOfWeek == 6) // 오늘이 주말인 경우를 계산
            {
                Console.WriteLine($">>> 오늘은 {today.DayOfWeek}입니다! 주중에 구매하지 못했다면 구매 가능합니다!");

            }
            else if ((int)today.DayOfWeek == b)         // 금일에 구매가능한 사람이라면
            {
                Console.WriteLine(">>> 구매 가능합니다!"); // 구매가능하다고 출력
                Console.WriteLine($">>> 오늘은 {today.DayOfWeek}입니다!");
            }
            else
            {
                Console.WriteLine(">>> 해당 요일이 아닙니다!");      // 그외의 경우라면
                Console.WriteLine($">>> 오늘은 {today.DayOfWeek}입니다!");    // 어떤 요일에 구매할 수 있는지 출력
                if (b == 1)  
                    Console.WriteLine($">>> {DayOfWeek.Monday}에 구매 가능합니다");
                else if (b == 2)
                    Console.WriteLine($">>> {DayOfWeek.Tuesday}에 구매 가능합니다");
                else if (b == 3)
                    Console.WriteLine($">>> {DayOfWeek.Wednesday}에 구매 가능합니다");
                else if (b == 4)
                    Console.WriteLine($">>> {DayOfWeek.Thursday}에 구매 가능합니다");
                else if (b == 5)
                    Console.WriteLine($">>> {DayOfWeek.Friday}에 구매 가능합니다");
            }
            Console.WriteLine();    // 줄바꿈하고 메소드 종료
        }

    }

    class Student : Person  // Person 클래스 상속
    {
        //필드구성 : 점수, 학점
        int score;
        char grade;

        public Student() : base()       // Student 생성자, base()를 통해 Person의 생성자 호출
        {
            Console.Write("점수 => ");    // 점수를 입력받고
            score = int.Parse(Console.ReadLine());
            grade = getGrade();         // 점수에 따라 학점 저장
        }

        public char getGrade() // 점수에 대한 학점 반환 (90이상 A, 80이상 B, 70이상 C, 60이상D, 그외 F)
        {
            if (score >= 90) return 'A';
            else if (score >= 80) return 'B';
            else if (score >= 70) return 'C';
            else if (score >= 60) return 'D';
            else return 'F';
        }

        public override void display()// disPlay() 오버라이딩, 점수, 학점 출력
        {
            base.display();         // 먼저 base를 통해 Person의 display 호출
            Console.WriteLine($"점수 : {score}\t학점 : {grade}");   // 그리고 점수와 학점 출력
        }
    }

    class Employee : Person // Person 클래스 상속
    {
        //필드구성 : 사번과 부서
        int identiNum;
        string department;

        public Employee() : base()          // Employee 생성자, base()를 통해 Person의 생성자 호출
        {
            Console.Write("사번 => ");        // 사번과 부서를 입력받는다
            identiNum = int.Parse(Console.ReadLine());
            Console.Write("부서 => ");
            department = Console.ReadLine(); 
        }

        public override void display() // disPlay() 오버라이딩, 사번과 부서 출력
        {
            base.display();              // 먼저 base를 통해 Person의 display 호출
            Console.WriteLine($"사번 : {identiNum}\t부서 : {department}");
        }
    }

    class Program
    {
        static void Main(string[] args)         // Main
        {
            Person[] obj;   //객체 배열 선언
            int count = 0;
            Console.Write("생성하고자 하는 객체 수를 입력하세요 :  ");
            int size = int.Parse(Console.ReadLine());
            obj = new Person[size];         // 입력받은 수 만큼 배열 생성

            do              // do - while 반복문
            {
                Console.Write("1. Student 생성  2. Employee 생성 ==> ");
                int num = int.Parse(Console.ReadLine());    // 객체 타입을 입력받고
                if (num == 1)       // 각각의 경우에 객체를 생성한다.
                {
                    obj[count] = new Student();
                    count++;        // 객체가 하나 생성되면 count 값 증가
                }
                else if (num == 2)
                {
                    obj[count] = new Employee();
                    count++;        // 객체가 하나 생성되면 count 값 증가
                }
                else
                    Console.WriteLine("입력오류!\n");   // 다르게 입력받으면 count증가없이 조건문을 빠져나간다
            } while (count < obj.Length);

            //객체 배열 원소 출력 & 공적 마스크 구매 가능 여부도 함께 출력
            for (int i = 0; i < obj.Length; i++)    // 반복문을 통해서
            {
                obj[i].display();           // 정보 출력
                obj[i].BuyPossible();       // 마스크 구매 가능 여부 출력
            } 
        }
    }
}
