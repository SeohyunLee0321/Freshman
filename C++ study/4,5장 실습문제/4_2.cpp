#include<iostream>
#include<cmath>
#include<iomanip>
using namespace std;

int main()
{
	double earth_r = 6378.1;

	double x1, x2, y1, y2;

	cout << "Enter point 1 (latitude and longtitude) in degrees : ";
	cin >> x1 >> y1;

	cout << "Enter point 2 (latitude and longtitude) in degrees : ";
	cin >> x2 >> y2;

	double great_circle_distance = earth_r * acos(sin(x1) * sin(x2) + cos(x1) * cos(x2) * cos(y1 - y2));
	cout << "The disance between the two points is : " << fixed << setprecision(11) << great_circle_distance << " km" << endl;

	return 0;
}
//계산 결과가 똑바로 나오지 않음 (이유를 알 수 없음)