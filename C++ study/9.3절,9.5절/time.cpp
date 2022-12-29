#include "time.h"
#include <ctime>
using namespace std;

Time::Time()
{
	int totalSeconds = time(0);
	second = totalSeconds % 60;
	int totalMinutes = totalSeconds / 60;
	minute = totalMinutes % 60;
	int totalHours = totalMinutes / 60;
	hour = totalHours % 24;
}

Time::Time(int total_second)
{
	int totalSeconds = total_second;
	second = totalSeconds % 60;
	int totalMinutes = totalSeconds / 60;
	minute = totalMinutes % 60;
	int totalHours = totalMinutes / 60;
	hour = totalHours % 24;
}

Time::Time(int nHour, int nMinute, int nSecond)
{
	hour = nHour;
	minute = nMinute;
	second = nSecond;
}

int Time::getHour()
{
	return hour;
}

int Time::getMinute()
{
	return minute;
}

int Time::getSecond()
{
	return second;
}

void Time::setTime(int elapseTime)
{
	int totalSeconds = time(0);
	second = totalSeconds % 60;
	int totalMinutes = totalSeconds / 60;
	minute = totalMinutes % 60;
	int totalHours = totalMinutes / 60;
	hour = totalHours % 24;
}