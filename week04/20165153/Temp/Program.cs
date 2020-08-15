using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Today;  //현재 날짜 정보를 today에 저장 
            var week = today.DayOfWeek;

            Console.WriteLine("year =" + today.Year);   //현재 년도
            Console.WriteLine("month =" + today.Month);  //현재 월
            Console.WriteLine("day =" + today.Day);  //현재 일
            Console.WriteLine("week = " + today.DayOfWeek);  //현재 요일, DayOfWeek  - 요일에 대한 열거형
            Console.WriteLine("num = " + (int)today.DayOfWeek);  //현재 요일에 해당하는 열거형 순서

       

        }
    }
}
