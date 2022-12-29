#include "Date.h"
#include <ctime>

// 현재 날짜에 대한 객체를 생성하는 생성자
Date::Date()
{
	// 전체 일
	int totalDays = time(0) / (60 * 60 * 24);
	// 1970년 ~ 현재 윤년 제거
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

// 달(year) 수를 계산하기 위한 함수
int Date::nowYearCal(int day)
{
	// 만약, 일(day) 수가 잘못된 경우 1 반환
	if (day < 1 || day > 365) return 1;

	int days[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
	// 윤년이면 2월을 29일로 바꿈
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

// 일(day) 수를 계산할 때 지나간 달 수를 계산하기 위한 함수
// ex) 현재 달이 2월이라면 31일 반환함
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

// 1970년 이후 윤년의 수를 세기 위한 함수
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
