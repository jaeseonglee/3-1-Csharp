/*	실습 2번
	작성일 : 2020.05.04
    작성자 : 20165153 이재성
	프로그램 설명 : 인터페이스를 제네릭을 이용하여 다양한 형에서 동작이 가능하도록 구현하는 클래스를 작성하고
            테스트 하시오. 단, 스택의 크기는 100.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2
{
    interface IOperation<T>  // 제네릭 인터페이스 IOperation<T>, 주어진 인터페이스에서 일부 자료형 및 타입변경
    {
        void Insert(T str);  //매개변수로 받은 str을 스택에 삽입(push)
        T Delete();          //스택 탑 원소 제거(pop) 후 반환
        bool Search(T str);  //매개변수로 받은 str 원소의 존재 여부 반환
        T GetCurrentElt();   //현재 스택 탑에 있는 원소 반환
        int NumOfElements(); //스택에 존재하는 원소 개수 반환
        void PrintStack();   //스택에 저장된 모든 원소 출력
    }

     class Stack<T> : IOperation<T>       // 인터페이스를 구현하는 제네릭 클래스 Stack
    {
        int index = 0;              // 현재 스택의 인덱스를 저정할 index  
        int size = 0;               // 스택의 크기를 저장할 size
        T[] arr;                    // 제네릭 타입의 배열 선언
        public Stack(int num)       // 생성자
        {
            arr = new T[num];       // 제네릭 타입 배열을 매개변수로 받은 값만큼의 크기로 생성
            size = num;             // size는 num으로 초기화
        }

        void IOperation<T>.Insert(T str)        
        {
            if(index + 1 > size )        // 현재 스택이 꽉찾다면 
                Console.WriteLine("스택이 전부 채워져있습니다.\n"); // 출력하고 메소드 종료
            else
            {
                arr[index] = str;       // 매개변수로 받은 값을 배열에 추가
                index++;                // 인덱스 값 증가
            } 
        }
        
        T IOperation<T>.Delete()
        {
            index--;                    // 인덱스 값 감소
            T temp = arr[index];        // 현재 가장 위에 있는 스택 값, 즉 배열에서 가장 뒤에 있는 값을 temp에 저장
            arr[index] = default(T);    // default(T)를 통해 배열값을 널값으로 초기화?
            return temp;                // temp에 저장된 값을 반환
        }

        bool IOperation<T>.Search(T str)
        {
            foreach(T i in arr)         // 반복문을 통해 서치
            {
                if (i.Equals(str))      // Equals를 통해 배열에서 매개변수로 받은 값이 있는지 확인
                    return true;        // 있으면 true 반환
            }
            return false;               // 없으면 false 반환
        }

        T IOperation<T>.GetCurrentElt() { return arr[index - 1]; }  // 현재 스택 탑에 있는 원소 반환
        int IOperation<T>.NumOfElements() { return index; }       //스택에 존재하는 원소 개수 반환
        void IOperation<T>.PrintStack() 
        {
            for(int i = index - 1; i >= 0 ; i--)            // 반복문을 사용하여 출력
            {
                Console.Write(arr[i]);
                if (i -1 >= 0) Console.Write(" => ");
            }
            Console.WriteLine();    // 출력이 다끝나면 줄바꿈
        }
    }

    class Program
    {

        static void Main(string[] args)         // Main
        {
            Stack<string> stack = new Stack<string>(100); // string 타입의 Stack 클래스 생성
            for (int i = 0; i < 3; i++)
            {
                Console.Write("삽입 : ");
                ((IOperation<string>)stack).Insert(Console.ReadLine()); // 문자열을 입력받아 스택 저장
            }
            Console.WriteLine("\n====== Stack Test ======");
            Console.WriteLine(">>>스택에 저장된 문자열 출력 :");
            ((IOperation<string>)stack).PrintStack();
            Console.WriteLine($">>>스택 탑 원소 제거 :\t{((IOperation<string>)stack).Delete()}");
            Console.WriteLine($">>>스택에 저장된 문자열 String A 찾기 :\t{((IOperation<string>)stack).Search("String A")}");
            Console.WriteLine($">>>스택 탑에 있는 원소 출력 :\t{((IOperation<string>)stack).GetCurrentElt()}");
            Console.WriteLine($">>>스택에 저장된 원소 개수 :\t{((IOperation<string>)stack).NumOfElements()}\n");

            Stack<double> stack1 = new Stack<double>(3);
            for (int i = 0; i < 3; i++)
            {
                Console.Write("삽입 : ");
                double temp = double.Parse(Console.ReadLine());     // 문자열을 입력받아 실수형으로 저장
                ((IOperation<double>)stack1).Insert(temp);          // Insert에 전달
            }
            Console.WriteLine("\n====== Stack Test ======");
            Console.WriteLine(">>>스택에 저장된 실수 출력 :");
            ((IOperation<double>)stack1).PrintStack();
            Console.WriteLine($">>>스택 탑 원소 제거 :\t{((IOperation<double>)stack1).Delete()}");
            Console.WriteLine($">>>53.5 찾기 :\t{((IOperation<double>)stack1).Search(53.5)}");
            Console.WriteLine($">>>스택 탑에 있는 원소 출력 :\t{((IOperation<double>)stack1).GetCurrentElt()}");
            Console.WriteLine($">>>스택에 저장된 원소 개수 :\t{((IOperation<double>)stack1).NumOfElements()}\n");
        }
    }
}
