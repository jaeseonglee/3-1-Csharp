/*	실습 1번
	작성일 : 2020.04.12
    작성자 : 20165153 이재성
	프로그램 설명 : 분수에 대한 클래스 작성
        1. 한 개의 정수를 받아 초기화하는 생성자를 작성하시오.
        2. 두 개의 정수를 받아 초기화하는 생성자를 작성하시오.
        3. 하나의 분수를 분자/분모 형태를 반환하는 ToString() 메소드를 작성하시오.
        4. 최대 공약수를 구하는 메소드와 기약 분수로 만드는 메소드를 작성하시오.
        5. 분수에 대한 사칙연산(+,-,*,/)을 수행하는 메소드를 작성하시오.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1
{
    class Fraction
    {
        public int numerator;       //분자
        public int denominator;     //분모
        public Fraction(int num) {  // 한 개의 정수를 받아 초기화하는 생성자를 작성하시오.
            numerator = num;
            denominator = 1;
        }

        public Fraction(int numer, int denomi) { // 두 개의 정수를 받아 초기화하는 생성자를 작성하시오.
            numerator = numer;
            denominator = denomi;
        }

        public String ToString() {  // 하나의 분수를 분자/분모 형태를 반환하는 ToString() 메소드를 작성하시오.
            return $"{numerator}/{denominator}";
        }

        private int GCD() {   // 최대 공약수를 구하는 메소드, Fraction 클래스에서만 사용하므로 private
            int? result = null;             // 결과를 저장할 변수 null 값으로 초기화
            int n = Math.Abs(numerator);    // 분자를 절대 값으로 저장

            // if문을 통해 분자와 분모중에 더 작은 값을 n에 저장
            if (Math.Abs(numerator) > Math.Abs(denominator)) { n = Math.Abs(denominator); }

            for(int i = 2; i <= n; i++) {   // 반복문을 통해 1보다 큰 최대 공약수를 찾는다
                if (numerator % i == 0 && denominator % i == 0 )
                    result = i;
            }

            return result ?? 1;         // 반복문을 통해 얻은 값이 있다면 그 값을 반환, 없다면 1을 반환
        }

        public void IrreducibleFraction() { // 기약 분수로 만드는 메소드를 작성하시오.
            int num = GCD();            // 최대 공약수 함수 GCD를 통해 값을 받는다
            if ( num > 1 ) {            // 1보다 큰 값이 저장 되었다면
                numerator /= num;       // 분자 분모를 그 값으로 나눠준다.
                denominator /= num;
            }
        }

        // 분수에 대한 사칙연산(+,-,*,/)을 수행하는 메소드를 작성하시오.
        public void AddFractin(Fraction f) {        // 덧셈인 AddFraction 함수
            int addNumer = numerator * f.denominator + denominator * f.numerator;   // 두 분수의 덧셈식을 저장
            int addDenomi = denominator * f.denominator;

            Fraction add = new Fraction(addNumer, addDenomi);   // 새로운 객체에 값을 넣어주고
            add.IrreducibleFraction();                          // 기약분수로 만들어준다.
            Console.WriteLine($"{ToString()} + {f.ToString()} = {add.ToString()}"); // 덧셈 결과 출력
        }

        public void SubtractionFractin(Fraction f) {    // 뺄셈인 SubtractionFractin 함수
            int subtractNumer = numerator * f.denominator - denominator * f.numerator;  // 두 분수의 뺄셈식 저장
            int subtractDenomi = denominator * f.denominator;

            Fraction subtract = new Fraction(subtractNumer, subtractDenomi);        // 새로운 객체에 값을 넣고
            subtract.IrreducibleFraction(); 
            Console.WriteLine($"{ToString()} - {f.ToString()} = {subtract.ToString()}");// 뺄셈 결과 출력
        }

        public void MultiFraction(Fraction f) { // 곱셈 MultiFraction 함수
            int multiNumer = numerator * f.numerator;       // 두 분수의 곱셈식 저장
            int multiDenomi = denominator * f.denominator;

            Fraction multi = new Fraction(multiNumer, multiDenomi);         // 새로운 객체에 값을 넣고
            multi.IrreducibleFraction();
            Console.WriteLine($"{ToString()} * {f.ToString()} = {multi.ToString()}");   // 곱셈 결과 출력
        }

        public void DivideFraction( Fraction f) {       // 나눗셈 DivideFraction 함수
            int didvideNumer = numerator * f.denominator;       // 두 분수의 나눗셈, 뒤쪽의 분수를 뒤집어 곱셈식으로 계산
            int didvideDenomi = denominator * f.numerator;

            Fraction didvide = new Fraction(didvideNumer, didvideDenomi);   // 객체에 값을 넣고
            didvide.IrreducibleFraction();
            Console.WriteLine($"{ToString()} / {f.ToString()} = {didvide.ToString()}"); // 나눗셈 결과 출력
        }

        ~Fraction() { }     // 소멸자
    }


    class Program
    {
        static void Main(string[] args) // Main 
        {
            Fraction c1, c2;            // 함수 객체 생성
            c1 = new Fraction(1, 2);
            c2 = new Fraction(3, 4);
            
            c1.AddFractin(c2);          // 사칙 연산 수행
            c1.SubtractionFractin(c2);
            c1.MultiFraction(c2);
            c1.DivideFraction(c2);

        }
    }
}
