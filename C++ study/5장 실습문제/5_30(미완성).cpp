#include<iostream>
using namespace std;

int main()
{//각 달의 첫번째 요일 출력
	int year;
	cout << "Enter year : ";
	cin >> year;
	int first_day;
	cout << "Enter year's first day : ";
	cin >> first_day;
    
	int add_day[12] = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30 };
	const char *day_of_week[7] = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

	bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

	if (isLeapYear)
	{
		add_day[1] = 29;
	}

	for (int i = 0; i <= 11; i++)
	{
		int days;
		days += add_day[i];

		cout << days;
	}
}