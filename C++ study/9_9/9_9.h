#pragma once
class LinearEquation
{
private:
	double a, b, c, d, e, f;

public:
	LinearEquation(double, double, double, double, double, double);
	double geta();
	double getb();
	double getc();
	double getd();
	double gete();
	double getf();

	bool isSolvable();

	double getX();
	double getY();
};


