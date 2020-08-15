/* 실습 1주차 : Number1.cs
   작성일 : 2020.03.21
   작성자 : 20165153 이재성
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
        static void Main(string[] args)
        {
            string answer;  //문자열 변수 선언, 문장 끝에는 반드시 ;
            Console.WriteLine(" C#은 처음인가요? ");  //표준 출력
            answer = Console.ReadLine();  //표준입력(문자열)
            Console.WriteLine(" C# 언어는  {0}  ", answer); //입력문자열 출력
            Console.WriteLine(" C# 언어는  " + answer);   //문자열 연결
            Console.WriteLine($" C# 언어는 {answer} ");  //문자열 보간
        }
    }
}
