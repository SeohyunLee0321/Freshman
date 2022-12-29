#ifndef FAN_H
#define FAN_H
#include<string>
using namespace std;

class Fan
{
private:
	int speed;
	bool on;
	double radius;
	string color;

public:
	Fan();

	void setSpeed(int);
	int getSpeed();

	void setOn(bool);
	bool getOn();

	void setRadius(double);
	double getRadius();

	void setColor(string);
	string getColor();
};

#endif