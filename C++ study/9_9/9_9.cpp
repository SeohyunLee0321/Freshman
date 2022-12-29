#include "9_9.h"
#include <iostream>
using namespace std;

LinearEquation::LinearEquation(double a, double b, double c, double d, double e, double f)
{
	a = 1;
	b = 1;
	c = 1;
	d = 1;
	e = 1;
	f = 1;
}

double LinearEquation::geta()
{
	return a;
}

double LinearEquation::getb()
{
	return b;
}

double LinearEquation::getc()
{
	return c;
}

double LinearEquation::getd()
{
	return d;
}

double LinearEquation::gete()
{
	return e;
}

double LinearEquation::getf()
{
	return f;
}

bool LinearEquation::isSolvable()
{
	if (a * d - b * c != 0)
		return true;
}

double LinearEquation::getX()
{
	return (e * d - b * f) / (a * d - b * c);
}

double LinearEquation::getY()
{
	return (a * f - e * c) / (a * d - b * c);
}
