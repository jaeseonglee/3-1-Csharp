/*	실습 2번
	작성일 : 2020.04.12
    작성자 : 20165153 이재성
	프로그램 설명 : 차량을 관리하는 프로그램을 제시된 조건대로 작성하시오
    	입력 받은 개수만큼 자동차 정보를 저장할 수 있는 배열을 생성한다
    	차량 정보를 입력하여 생성된 배열에 저장한다
	    검색하고자 하는 차량 번호를 입력 받아 소유자와 연락처를 출력한다
	    해당 자료가 없으면 “해당 차량이 없습니다”를 출력한다
	    문자열 인덱스(차량번호)를 매개변수로 받아 처리하는 인덱서를 작성하시오 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2
{   
    class Car
    {
        private string[] info;  // 입력 받은 개수만큼 자동차 정보를 저장할 수 있는 배열을 생성한다
        public Car(int num)     // 생성자
        {
            info = new string[num]; // 배열 초기화
            for(int i = 0; i < num; i++)        // 반복문을 통해 차량 정보를 입력하여 생성된 배열에 저장한다
            {
                Console.Write("차량 소유자 : ");
                string name = Console.ReadLine();
                Console.Write("차량 번호 : ");
                string carNumber = Console.ReadLine();
                Console.Write("연락처 : ");
                string phone = Console.ReadLine();
                info[i] = $"차번호 {carNumber} = 소유자 : {name} 연락처 : {phone}";
            }
        }

        public int Size => info.Length; // 배열의 길이 만큼 Size에 저장

        public string this[int index]   // 정수로 입력받는 인덱서
        {
            get { return info[index]; } // 인덱스에 해당하는 값 반환
        }

        public string this[string key]  // 문자열로 입력받는 인덱서
        {
            get
            {
                string element = FindKey(key); //키에 해당하는 요소 문자열을 찾는다.
                return GetValue(element); //요소 문자열에서 값을 추출하여 반환한다.
            }
        }
        
        private string FindKey(string key)      // 문자열을 반환하는 FindKey함수
        {
            foreach (string s in info)
            {  //보관된 각 요소에 대해 반복 수행
                if (s.IndexOf(key) == 4)        // 처음 문자열을 초기화할 때 차번호의 위치인 4에서 검색
                    return s; //요소 문자열 반환
            }
            return "=해당 차량이 없습니다";      // 없으면 해당차량이 없다고 반환
        }

        private string GetValue(string s)       // 문자열에서 차량 소유자와 연락처를 반환하는 GetValue 함수
        {
            int index = s.IndexOf('=');  //'='문자가 시작되는 위치 검색
            return s.Substring(index + 1); //index+1 뒤에 있는 부분 문자열 반환
        }
}

class Program
    {
        static void Main(string[] args)     // Main
        {
            Car md;                     // Car 객체 선언
            Console.Write(" 저장하고자 하는 데이터 갯수를 입력하세요 >> ");
            md = new Car(int.Parse(Console.ReadLine()));    // 입력받은 값으로 생성자의 매개변수로 전달, 그만큼 배열 생성
            Console.WriteLine("____________________");
            Console.WriteLine("\n **** 전체 데이터 리스트 **** ");

            for (int i = 0; i < md.Size; i++)           // 반복문을 통해 출력
            {
                Console.WriteLine(i + " ) " + md[i]); //정수를 인자로 받는 인덱서 사용
            }

            Console.Write(" 차량 번호를 입력하세요 >> ");
            string result = md[Console.ReadLine()];
            Console.WriteLine("____________________");
            Console.WriteLine(result);  //문자열 인자로 받는 인덱서 사용}
        }
    }
}
