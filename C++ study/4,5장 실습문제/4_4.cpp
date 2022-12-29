#include<iostream>
#include<iomanip>
using namespace std;

int main()
{
	double side;
	cout << "Enter the side : ";
	cin >> side;

	const double PI = 3.14159;
	double area_hexagon = (6.0 * side * side) / (4.0 * tan(PI / 6.0));

	cout << "The area of the hexagon is " << fixed << setprecision(2) << area_hexagon;

	return 0;
}