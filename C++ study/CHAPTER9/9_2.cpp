#include<iostream>
#include "9_2.h"
using namespace std;

Fan::Fan()
{
	speed = 1;
	on = false;
	radius = 5;
}

int Fan::getSpeed()
{
	return speed;
}

void Fan::setSpeed(int newSpeed)
{
	speed = newSpeed;
}

bool Fan::getOn()
{
	return on;
}

double Fan::getRadius()
{
	return radius;
}

int main()
{
	Fan fan1(3, true, 10.0);
	Fan fan2(2, false, 5.0);

	cout << "Fan 1 has speed of " << fan1.getSpeed() << ", radius of " << fan1.getRadius()
		<< " and bool of turned on is " << fan1.getOn() << endl;
	cout << "Fan 2 has speed of " << fan2.getSpeed() << ", radius of " << fan2.getRadius()
		<< " and bool of turned on is " << fan2.getOn() << endl;
}