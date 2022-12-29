#include <iostream>
using namespace std;

int main()
{
	const double PI = 3.14159;

	//1단계 : 반지름 읽기
	double radius;
	cout << "반지름을 입력하세요: ";
	cin >> radius;

	//2단계 : 계산
	double circle_area = radius * radius * PI;                //원의 면적
	double circumference = radius * 2 * PI;                   //원의 둘레
	double area_circumscribed_square = 4 * radius * radius;   //외접 사각형 면적
	double area_inscribed_square = 2 * radius * radius;       //내접 사각형 면적

	//3단계 : 결과 출력
	cout << "원의 면적: ";
	cout << circle_area << endl;
	cout << "원이 둘레: ";
	cout << circumference << endl;
	cout << "외접 사각형의 면적: ";
	cout << area_circumscribed_square << endl;
	cout << "내접 사각형의 면적: ";
	cout << area_inscribed_square << endl;

	return 0;
}