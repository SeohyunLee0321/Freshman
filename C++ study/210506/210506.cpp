#include<iostream>
#include<cmath>
#include<iomanip>
using namespace std;

int main()
{
	const double PI = 3.14159;
	
	double r;
	cout << "Enter the length from the center to a vertex : ";
	cin >> r;

	double s = r * sin(PI / 5.0) * 2;

	double area = (5 * pow(s,2)) / (4.0 * tan(PI / 5.0));

	cout << "The area of the pentagon is " << fixed << setprecision(2) << area << endl;

	return 0;
}