#include <iostream>
#include <ctime>
using namespace std;

int main()
{
	// 1970��1�� 1�� ���� ������ �� �� ���
	int totalSeconds = time(0);

	// ���� �ð��� �� �� ���
	int currentSeconds = totalSeconds % 60;

	// ��ü �� �� ���
	int totalMinutes = totalSeconds / 60;

	// ���� �� �� ���
	int currentMinutes = totalMinutes % 60;

	// ��ü �ð� �� ���
	int totalHours = totalMinutes / 60;

	// ���� �ð� ���
	int currentHours = (totalHours + 9) % 24;                //Ʋ����

	// ��� ȭ�� ���
	cout << "Current time is " << currentHours << "hours : " << currentMinutes << "minutes : " << currentSeconds << "seconds KST " << endl << endl;



	cout << "<���� #1>" << endl;
	cout << "0�� 9 ������ ������ 3�� �Է��ϼ���: ";
	
	int num1, num2, num3;
	cin >> num1 >> num2 >> num3;
	
	int result1 = 100 * num1 + 10 * num2 + num3;
	
	cout << "==> 3���� ���� �̷���� ������ : " << result1 << endl << endl;



	cout << "<���� #2>" << endl;
	cout << "0 �� 999 ������ ������ �Է��ϼ��� : ";
	
	int num4;
	cin >> num4;
	
	int num5 = num4 % 10;                   // 1���ڸ�
	int num7 = num4 / 100;                  // 100���ڸ�
	int num6 = num4 / 10 - num7 * 10;       // 10���ڸ�
	
	int result2 = num5 + num6 + num7;
	
	cout << "==> �� �ڸ����� �� : " << result2 << endl << endl;



	cout << "<���� #3>" << endl;
	cout << "0 �� 31 ������ ������ �Է��ϼ��� : ";
	
	int num8;
	cin >> num8;
	
	int num9 = num8 % 2;
	int num10 = num8 / 2 % 2;
	int num11 = num8 / 2 / 2 % 2;
	int num12 = num8 / 2 / 2 / 2 % 2;
	int num13 = num8 / 2 / 2 / 2 / 2 % 2;
	
	cout << "==> " << num8 << "(������) = " << num13 << num12 << num11 << num10 << num9 << "(������)" << endl;

		return 0;
}