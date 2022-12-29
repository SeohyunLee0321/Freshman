#include<iostream>
#include<cmath>
using namespace std;

double getDiscriminant(double a, double b, double c)
{
	return b * b - 4 * a * c;
}

double getRoot1(double a, double b, double c)
{
	return (-b + sqrt(b * b - 4 * a * c)) / (2 * a);
}

double getRoot2(double a, double b, double c)
{
	return (-b - sqrt(b * b - 4 * a * c)) / (2 * a);
}

void QuardraticEquation(double a, double b, double c)
{
	if (getDiscriminant(a, b, c) > 0)
	{
		cout << "The equation has " << getRoot1(a, b, c) << " and " << getRoot2(a, b, c);
	}

	else if (getDiscriminant(a, b, c) == 0)
	{
		cout << "The equation has " << getRoot1(a, b, c);
	}

	else
	{
		cout << "The equation has no real roots";
	}
}

int main()
{
	double a, b, c;
	cout << "ax^2 + bx + c = 0의 a, b, c의 값을 입력하세요" << endl;
	cin >> a >> b >> c;
	QuardraticEquation(a, b, c);
}