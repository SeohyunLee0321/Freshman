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
//switch와 if문엔 string이 들어갈 수 없다고한다. 해결방법을 찾지 못했다.