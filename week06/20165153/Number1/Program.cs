/*	실습 1번
	작성일 : 2020.05.04
    작성자 : 20165153 이재성
	프로그램 설명 : 다음과 같이 다양한 자료형을 갖는 배열에서 특정 원소의 개수를 계산하여 출력하는 프로그램을 작성하시오.
        단 첫번째 매개변수로 배열을 전달하고, 두번째 매개변수로 찾고자 하는 값을 전달하여 결과를 반환받는 
        Search() 메소드를 제네릭으로 구현하여 사용할 것.
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
        static int Search<T>(T[] arr, T value){ // 배열과 찾고자하는 값을 인자로 받는 Search 제네릭 메소드
            int cnt = 0;            // 개수를 저장할 cnt
            foreach(T n in arr)     // foreach문을 통래 개수 계산
            {
                if(n.Equals(value)) // 제네릭 타입으로 '==' 비교연산이 되지않아 Equals를 사용해 비교
                    cnt++;          // Equals의 결과가 true라면 cnt 값 증가
            }
            return cnt;             // 반복문이 끝나면 cnt 반환
        }

        static void Main(string[] args)         // Main
        {
            var array = new int[] { 5, 2, 6, 3, 6, 8, 2, 1, 6, 4 };                 //정수 6의 개수
            var str = new string[] { "사과", "포도", "사과", "토마토", "천혜향" };  //문자열 “사과” 개수
            Console.WriteLine($"array : cnt = {Search(array, 6)}"); // array 배열과 6을 인자로 전달
            Console.WriteLine($"str : cnt = {Search(str, "사과")}");// str 배열과 "사과"를 인자로 전달
        }
    }
}
