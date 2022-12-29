#include <iostream>
#include <iomanip>
#include "9_9.h"
using namespace std;

int main()
{
	cout << "ax + by = e" << endl;
	cout << "cx + dy = f" << endl;

	cout << "Enter a, b, c, d, e, f: ";
	double a, b, c, d, e, f;
	cin >> a >> b >> c >> d >> e >> f;

	//위 코드들에서 정의 후 객체 생성
	LinearEquation LinearEquation(a, b, c, d, e, f);

	if (LinearEquation.isSolvable());
	{
		cout << fixed << setprecision(1);
		cout << "x is " << LinearEquation.getX() << " and y is " << LinearEquation.getY() << endl;
	}

	if (a * d - b * c == 0)
		cout << "The equation has no solution" << endl;

	cout << "x is " << (e * d - b * f) / (a * d - b * c) << endl;
	cout << "y is " << (a * f - e * c) / (a * d - b * c) << endl;
}