#ifndef TIME_H
#define TIME_H

class Time {
public: Time();
		Time(int);
		Time(int nHour, int nMinute, int nSecond);
		int getHour();
		int getMinute();
		int getSecond();
		void setTime(int elapseTime);
private:
	int hour;
	int minute;
	int second;
};

#endif
