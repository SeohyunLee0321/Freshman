#ifndef LINEAREQUATION_H
#define LINEAREQUATION_H

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

	bool isSolvable(double, double, double, double);

	double getX(double, double, double, double, double, double);
	double getY(double, double, double, double, double, double);
};

#endif