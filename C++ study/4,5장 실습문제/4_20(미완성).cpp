#include<iostream>
#include<iomanip>
#include<string>
using namespace std;

int main()
{
	int year;
	cout << "Enter a year : ";
	cin >> year;

	string month;
	cout << "Enter a month : ";
	cin >> month;

	if (static_cast<char>(month.at(0)) < 65 || static_cast<char>(month.at(0)) > 90)
		cout << month << " is not a corect month name" << endl;

	bool isLeapYear =
		(year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

	return 0;
}
//switch�� if���� string�� �� �� ���ٰ��Ѵ�. �ذ����� ã�� ���ߴ�.