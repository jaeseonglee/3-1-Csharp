/*	실습 5번
	작성일 : 2020.05.05
    작성자 : 20165153 이재성
	프로그램 설명 : List  제네릭 컬렉션 클래스를 사용하여 동아리 회원 가입과 탈퇴를 처리하는 프로그램을 작성하시오.
                단, 프로그램을 종료하면 List에 저장된 모든 데이터를 파일로 출력한다.
*/
using System;
using System.Collections.Generic;       // List 사용 위해 using System.Collections.Generic
using System.Linq;
using System.IO;                        // 파일 처리를 위해 using System.IO
using System.Text;
using System.Threading.Tasks;

namespace Number5
{
    public class Member     // Member 클래스
    {
        //필드구성 – 이름, 아이디, 가입년도, 가입 월
        public string Name { get; set; }    // 각 필드 구성에 대한 프로퍼티
        public string Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }

        //생성자 : 이름과 아이디를 매개변수로 받아서 필드초기화, 단, 가입년도와 가입월은 DateTime 사용 
        public Member(string n, string i) 
        {
            Name = n;
            Id = i;
            Year = DateTime.Now.Year;       // DataTime을 이용해서 현재 연도와 월로 초기화
            Month = DateTime.Now.Month;
        }
        
        public override string ToString()   // ToString 오버라이딩, 객체가 가진 정보 출력
        {
            //객체 정보를 문자열로 반환
            return $"Customer [name={Name}, id={Id}, year={Year}, month={Month}]";
        }

    }
    class Program
    {
        static void Main(string[] args)     // Main
        {
            var list = new List<Member>();  // Member를 제네릭 타입으로 갖는 List
            string nameWord;
            string idWord;
            bool b = true;

            while (b)               // b의 값이 바뀌기 전까지 무한 반복문
            {
                Console.Write("1:회원가입\t2:회원탈퇴\t3:종료 >> ");  // 메뉴 출력
                int num = int.Parse(Console.ReadLine());            // 정수를 입력받는다.

                switch (num)                // switch문
                {
                    case 1:                 // 1일 경우 추가
                        Console.Write("> 이름을 입력하세요 : ");    // 이름과
                        nameWord = Console.ReadLine();
                        Console.Write("> 아이디를 입력하세요 : ");  // 아이디를 입력받고
                        idWord = Console.ReadLine();
                        list.Add(new Member(nameWord, idWord));     // 객체 생성후 Add를 통해 저장
                        break;

                    case 2:                 // 2일 경우 검색후 삭제
                        Console.Write("> 아이디를 입력하세요 : ");      // 아이디를 입력받고
                        idWord = Console.ReadLine();
                        var exists = list.Any(x => x.Id == idWord );    // 람다식에 해당하는 조건이 있을경우 true를 반환하는 Any
                        if (exists)         // true라면
                        {                            
                            list.RemoveAll(x => x.Id == idWord);    // 입력받은 아이디에 맞는 정보를 삭제하고
                            foreach (var i in list)                 // 남은 list의 정보들을 출력한다.
                                Console.WriteLine(i.ToString());
                        }
                        else
                        {               // false라면
                            Console.WriteLine("해당 아이디가 없습니다."); // 해당 아이디가 없다고 출력
                        }
                        break;
                    case 3:             // 3이라면 종료
                        Console.WriteLine("프로그램을 종료합니다.");      // 종료한다고 출력
                        b = false;      // b를 false로 초기화
                        
                        // using을 써줌으로써 close를 안써줘도 된다.
                        using(var s = new StreamWriter(@"C:\Users\SAMSUNG\Desktop\C# 6주차\20165153\Number5\test.txt", append:true))
                        {                                // 그냥 test.txt 생성시 .\bin\Debug에 파일이 생성된다.
                            foreach (var i in list)
                                s.WriteLine(i.ToString());  // 남은 list의 정보들을 test.txt로 출력해준다.
                        }
                        break;
                    default:
                        Console.WriteLine("입력 오류! 다시 입력해주세요!"); // 그외 다른 값은 다시 입력해달라고 출력
                        break;
                }
            }
        }
    }
}
