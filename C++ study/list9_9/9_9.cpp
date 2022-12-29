#include<iostream>
#include <iomanip>
#include "9_9.h"
using namespace std;

LinearEquation::LinearEquation(double, double, double, double, double, double)
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

bool LinearEquation::isSolvable(double a, double b, double c, double d)
{
	if (a * d - b * c != 0)
		return true;
}

double LinearEquation::getX(double a, double b, double c, double d, double e, double f)
{
	return (e * d - b * f) / (a * d - b * c);
}

double LinearEquation::getY(double a, double b, double c, double d, double e, double f)
{
	return (a * f - e * c) / (a * d - b * c);
}

int main()
{
	cout << "ax + by = e" << endl;
	cout << "cx + dy = f" << endl;

	cout << "Enter a, b, c, d, e, f: ";
	double a, b, c, d, e, f;
	cin >> a >> b >> c >> d >> e >> f;

	LinearEquation LinearEquation(a, b, c, d, e, f);

	if (LinearEquation.isSolvable(a, b, c, d) == true)
	{
		cout << fixed << setprecision(1);
		cout << "x is " << LinearEquation.getX(a, b, c, d, e, f) << " and y is " << LinearEquation.getY(a, b, c, d, e, f) << endl;
	}
	else
	{
		cout << "The equation has no solution" << endl;
	}

	return 0;
}