/*	실습 3번
	작성일 : 2020.04.12 ~ 13
    작성자 : 20165153 이재성
	프로그램 설명 : 아이디와 비밀번호를 관리하는 프로그램을 완성하시오.
        S를 입력하면 프로그램이 종료되며 대소문자를 구분하지 않는다
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number3
{
    class Person  //Person 클래스에 대한  생성자 없음
    {
        int pass;  //비밀번호
        string id; //아이디

        //비밀번호와 아이디에 대한 프로퍼티 정의 – 본인작성
        public int Pass             // 비밀번호에 대한 프로퍼티
        { 
            get { return pass; }
            set { pass = value; }
        }

        public string Id            // 아이디에 대한 프로퍼티
        {
            get { return id; }
            set { id = value; }
        }
    }

    class PersonManage
    {
        Person[] people;        // Person 객체 배열 선언
        int index = 0;          // 변수 index 선언 및 0으로 초기화
        Random rnd;             // 난수 생성을 위한 Random 객체 선언

        //크기가 50인 Person 배열 객체 생성하고 난수를 위한 객체를 생성하는 생성자 – 본인 작성
        public PersonManage()               // 생성자
        {
            people = new Person[50];        // 크기가 50인 배열로 초기화
            rnd = new Random();             // 난수를 위한 객체 생성
        }
 
        //아이디를 입력받으며 비밀번호는 1부터 100사이의 난수를 생성하여 저장 하는 메소드 – 본인작성
        public void MakePerson(string word)      
        {
            people[index] = new Person();   // 현재 인덱스에 대한 객체 생성
            people[index].Id = word;        // id 저장
            int data = rnd.Next() % 100 + 1; //1부터 100사이의 난수 생성
            people[index].Pass = data;      // 난수로 생성된 값을 비밀번호로 저장
            index++;                        // 아이디와 비밀번호 저장이 끝나면 index 증가
        }

        //문자열 id를 매개변수로 받아 id에 해당하는 비밀번호를 반환하는 인덱서 – 본인작성
        public int this[string key]         // 인덱서
        {
            get
            {
                int result = ReturnPassword(key);
                return result;
            }
        }

        //매개변수로 받은 문자열 id와 일치하는 비밀번호 반환, 없으면 0을 반환하는 메소드 – 본인작성

        public int ReturnPassword(string key)     
        {
            for(int i = 0; i < index; i++)      // 반복문을 통해 비밀번호 반환
            {
                if(people[i].Id == key)
                {
                    return people[i].Pass;
                }
            }

            return 0;                   // 없으면 0을 반환
        }

        //배열에 저장된 모든 내용을 출력하는 메소드 – 본인작성
        public void PrintPerson()
        {
            for(int i = 0; i< index; i++)       // 반복문을 통해 모든 Person 출력
            {
                Console.WriteLine($"id = {people[i].Id} pass = {people[i].Pass}");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // PersonManage 객체를 생성하고 제시된 결과처럼 입력된 메뉴를 처리 – 본인작성
            PersonManage pm = new PersonManage();       // 객체 생성

            while (true)                // 무한 반복문을 통해 메뉴 처리
            {
                Console.Write("1:저장, 2:검색, 3:출력, 종료하려면 s를 입력하세요 : ");
                string menu = Console.ReadLine();       // 키보드로부터 메뉴를 입력받음

                if (menu == "s" || menu == "S") break;  // s 또는 S를 입력받으면 프로그램 종료

                switch (int.Parse(menu))            // switch문을 통해 메뉴 처리
                {
                    case 1:                         // 1이 입력되면 아이디 저장
                        Console.Write("아이디를 입력하세오 >>> ");
                        pm.MakePerson(Console.ReadLine());
                        break;

                    case 2:                         // 2가 입력되면 아이디에 대한 비밀번호 검색
                        Console.Write("검색하고자 하는 아이디 >>> ");
                        int n = pm.ReturnPassword(Console.ReadLine());
                        Console.WriteLine($"비밀번호 : {n}");
                        break;

                    case 3:                         // 3이 입력되면 전부 출력
                        pm.PrintPerson();
                        break;

                    default:                        // 그외의 입력은 입력 오류 처리로 다시 입력받도록함
                        Console.WriteLine("입력 오류!");
                        break;
                }
            }

        }
    }

}
