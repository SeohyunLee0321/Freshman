#include<iostream>
#include<cmath>
#include<iomanip>
using namespace std;

int main()
{ //모서리 점 좌표 구하기
	double r;
	int n;
	cout << "Enter a radius and number of sides ";
	cin >> r >> n;

	const double PI = 3.14159;
	double radian = 2 * PI / n;
	double x, y;

	for (int i = 1; i <= n; i++)
	{
		x = r * cos(radian * i);
		y = r * sin(radian * i);

		cout << "The coordinate of corner" << fixed << setprecision(2) << i << " is (" << x << ", " << y << ")\n";
	}

	return 0;
}