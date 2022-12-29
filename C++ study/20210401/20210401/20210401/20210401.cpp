#include <iostream>
#include <ctime>
using namespace std;

int main()
{
	// 1970년1월 1일 자정 이후의 초 값 계산
	int totalSeconds = time(0);

	// 현재 시간의 초 값 계산
	int currentSeconds = totalSeconds % 60;

	// 전체 분 값 계산
	int totalMinutes = totalSeconds / 60;

	// 현재 분 값 계산
	int currentMinutes = totalMinutes % 60;

	// 전체 시간 값 계산
	int totalHours = totalMinutes / 60;

	// 현재 시간 계산
	int currentHours = (totalHours + 9) % 24;                //틀렸음

	// 결과 화면 출력
	cout << "Current time is " << currentHours << "hours : " << currentMinutes << "minutes : " << currentSeconds << "seconds KST " << endl << endl;



	cout << "<문제 #1>" << endl;
	cout << "0과 9 사이의 정수를 3개 입력하세요: ";
	
	int num1, num2, num3;
	cin >> num1 >> num2 >> num3;
	
	int result1 = 100 * num1 + 10 * num2 + num3;
	
	cout << "==> 3개의 수로 이루어진 십진수 : " << result1 << endl << endl;



	cout << "<문제 #2>" << endl;
	cout << "0 과 999 사이의 정수를 입력하세요 : ";
	
	int num4;
	cin >> num4;
	
	int num5 = num4 % 10;                   // 1의자리
	int num7 = num4 / 100;                  // 100의자리
	int num6 = num4 / 10 - num7 * 10;       // 10의자리
	
	int result2 = num5 + num6 + num7;
	
	cout << "==> 각 자리수의 합 : " << result2 << endl << endl;



	cout << "<문제 #3>" << endl;
	cout << "0 과 31 사이의 정수를 입력하세요 : ";
	
	int num8;
	cin >> num8;
	
	int num9 = num8 % 2;
	int num10 = num8 / 2 % 2;
	int num11 = num8 / 2 / 2 % 2;
	int num12 = num8 / 2 / 2 / 2 % 2;
	int num13 = num8 / 2 / 2 / 2 / 2 % 2;
	
	cout << "==> " << num8 << "(십진수) = " << num13 << num12 << num11 << num10 << num9 << "(이진수)" << endl;

		return 0;
}