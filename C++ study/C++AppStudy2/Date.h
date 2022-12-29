#ifndef DATE_H
#define DATE_H

class Date
{
public:
	Date();
	Date(int nowSec);
	Date(int nYear, int nMonth, int nDay);
	int getYear();
	int getMonth();
	int getDay();
	void setDate(int elapseTime);
	int nowYearCal(int day);
	int yearsCal(int mon);
	int leapYear(int days);

private:
	int year;
	int month;
	int day;
};

#endif
