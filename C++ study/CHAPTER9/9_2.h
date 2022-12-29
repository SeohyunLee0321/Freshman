#ifndef FAN_H
#define FAN_H

class Fan
{
private:
	int speed;
	bool on;
	double radius;

public:
	Fan();
	Fan(int speed, bool on, double radius);

	void setSpeed(int);
	int getSpeed();

	void setOn(bool);
	bool getOn();

	void setRadius(double);
	double getRadius();
};

#endif