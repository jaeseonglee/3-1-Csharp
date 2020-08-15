using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    class MyDictionary
    {
        string[] storage = new string[5];
        public MyDictionary(string[] name)
        {
            for (int i = 0; i < storage.Length; i++)
            {
                storage[i] = $"{name[i]} = pass:{(i + 1) * 100}";
                // storage[i]=string.Format("name{0} = pass:{1}", name[i], (i+1)*100);
            }
        }
        public int Size => storage.Length;  //배열 storage 크기 반환

        public string this[int index]
        { //정수를 매개변수로 받는 인덱서
            get
            {
                if (AvailIndex(index))
                { //유효한 인덱스일 때
                    return GetValue(storage[index]); //storage[index] 요소의 값을 반환
                }
                return string.Empty;
            }
        }
        public string this[string key]
        { //문자열을 매개변수로 받는 인덱서
            get
            {
                string element = FindKey(key); //키에 해당하는 요소 문자열을 찾는다.
                return GetValue(element); //요소 문자열에서 값을 추출하여 반환한다.
            }
        }
        private bool AvailIndex(int index)
        {  //유효한 인덱스인지 검사
            return (index >= 0) && (index < storage.Length);
        }
        private string FindKey(string key)
        {
            foreach (string s in storage)
            {  //보관된 각 요소에 대해 반복 수행
                if (s.IndexOf(key) == 0)
                {  //요소 문자열이 key로 시작할 때
                    return s; //요소 문자열 반환
                }
            }
            return string.Empty;
        }
        private string GetValue(string s)
        {
            int index = s.IndexOf('=');  //'='문자가 시작되는 위치 검색
            return s.Substring(index + 1); //index+1 뒤에 있는 부분 문자열 반환
        }
        public void disPlay()
        {
            foreach (var value in storage) Console.WriteLine(value);
        }
    }
    class Program
    {
        static void Main(string[] args) { 
            MyDictionary md = new MyDictionary(new string[] { "choi", "kim", "park", "lee", "hwa" });
            md.disPlay();   Console.WriteLine("____________________");
            for (int i = 0; i<md.Size; i++){
                Console.WriteLine(md[i]); //정수를 인자로 받는 인덱서 사용
            }
            Console.WriteLine("____________________");
            Console.WriteLine(md["park"]); //문자열 인자로 받는 인덱서 사용
        }
 }

}
