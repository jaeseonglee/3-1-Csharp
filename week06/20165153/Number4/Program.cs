/*	실습 4번
	작성일 : 2020.05.05
    작성자 : 20165153 이재성
	프로그램 설명 : 제시된 결과처럼 Dictionary 제네릭 컬렉션 클래스를 사용하여 축약어를 처리하는 프로그램을 작성하시오
*/
using System;
using System.Collections.Generic;       // Dictionary 사용위해 using System.Collection.Generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number4
{
    class Program
    {
        static void Main(string[] args)     // Main
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();  // 딕셔너리 키와 밸류 둘다 string
            string wordKey;
            string wordValue;
            bool b = true;
            while(b)            // b의 값이 바뀌기 전까지 무한 반복문  
            {
                Console.Write("1:추가 2:검색 3:출력 4:종료\n>> ");// 메뉴 출력
                int num = int.Parse(Console.ReadLine());         // 정수를 입력받는다.

                switch (num)                // switch문
                {
                    case 1:                 // 1일 경우 컬렉션 추가
                        Console.Write("> 축약어 : ");
                        wordKey = Console.ReadLine();
                        Console.Write("> 의미 : ");
                        wordValue = Console.ReadLine();
                        dic.Add(wordKey, wordValue);        // Add를 통해 추가해준다.
                        break;
                    
                    case 2:                     // 2일 경우 키 값 검색
                        Console.Write("> 축약어 : ");
                        wordKey = Console.ReadLine();
                        int cnt = 0;
                        foreach(var i in dic.Keys)      // foreach를 통해
                        {
                            if (i == wordKey)           // 입력된 키값이 딕셔너리 내에 있다면
                            {
                                Console.WriteLine($"word) {wordKey},\tmean) {dic[wordKey]}");   // 그에 맞는 밸류 출력
                                cnt++;    
                                break;
                            }
                        }

                        if (cnt == 0)           // 위의 반복문에서 찾지 못하면 찾지 못했다고 출력
                            Console.WriteLine("입력된 축약어에 대한 저장된 의미가 없습니다!");
                        break;
                    case 3:                     // 3일 경우 모두 출력
                        foreach (KeyValuePair<string, string> kv in dic)    // KeyValuePair를 사용
                            Console.WriteLine($"word) {kv.Key},\tmean) {kv.Value}"); // 키와 밸류 둘다 출력에 편리
                        break;
                    case 4:
                        b = false;      // 4일 경우 b의 값을 false로 바꿔줌으로써 전체 반복문이 종료된다.
                        break;
                    default:
                        Console.WriteLine("입력 오류! 다시 입력해주세요!"); // 그외 다른 값은 다시 입력해달라고 출력
                        break;
                }
  
            }
        }
    }
}
