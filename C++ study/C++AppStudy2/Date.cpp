#include "Date.h"
#include <ctime>

// ���� ��¥�� ���� ��ü�� �����ϴ� ������
Date::Date()
{
	// ��ü ��
	int totalDays = time(0) / (60 * 60 * 24);
	// 1970�� ~ ���� ���� ����
	totalDays -= leapYear(totalDays);
	year = 1970 + (totalDays / 365);
	month = nowYearCal(totalDays % 365);
	day = totalDays % 365 - yearsCal(month);
}

Date::Date(int nowSec)
{
	int totalDays = nowSec / (60 * 60 * 24);
	totalDays -= leapYear(totalDays);
	year = 1970 + (totalDays / 365);
	month = nowYearCal(totalDays % 365);
	day = totalDays % 365 - yearsCal(month);
}

Date::Date(int nYear, int nMonth, int nDay)
{
	year = nYear;
	month = nMonth;
	day = nDay;
}

int Date::getYear()
{
	return year;
}

int Date::getMonth()
{
	return month;
}

int Date::getDay()
{
	return day;
}

void Date::setDate(int elapseTime)
{
	int totalDays = elapseTime / (60 * 60 * 24);
	totalDays -= leapYear(totalDays);
	year = 1970 + (totalDays / 365);
	month = nowYearCal(totalDays % 365);
	day = totalDays % 365 - yearsCal(month);
}

// ��(year) ���� ����ϱ� ���� �Լ�
int Date::nowYearCal(int day)
{
	// ����, ��(day) ���� �߸��� ��� 1 ��ȯ
	if (day < 1 || day > 365) return 1;

	int days[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
	// �����̸� 2���� 29�Ϸ� �ٲ�
	if (day % 4 == 0 && ((day % 100 != 0) || (day % 400 == 0)))
	{
		days[1] = 29;
	}
	for (int i = 0; i < sizeof(days) / sizeof(days[0]); i++)
	{
		if (day <= days[i]) return i + 1;
		day -= days[i]; 
	}
}

// ��(day) ���� ����� �� ������ �� ���� ����ϱ� ���� �Լ�
// ex) ���� ���� 2���̶�� 31�� ��ȯ��
int Date::yearsCal(int mon)
{
	int sum = 0;
	int days[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
	for (int i = 0; i < mon - 1; i++)
	{
		sum += days[i];
	}
	return sum;
}

// 1970�� ���� ������ ���� ���� ���� �Լ�
int Date::leapYear(int d)
{
	int cnt = 0;
	int y = d / 365;
	int m = nowYearCal(d % 365);
	if (m <= 2) y--;
	for (int i = 1; i <= y; i++)
	{
		if (i % 4 == 0 && ((i % 100 != 0) || (i % 400 == 0)))
		{
			cnt++;
		}
	}

	return cnt;
}
