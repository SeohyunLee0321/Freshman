#include<iostream>
#include<cmath>
#include<iomanip>
#include<ctime>
using namespace std;

int main()
{
	//0~360 각도 생성
	srand(time(0));            
	double a = rand() % 360;
	double b = rand() % 360;
	double c = rand() % 360;
		
	//라디안으로 변경
	const double PI = 3.14159; 
	double A = a * PI / 180.0;
	double B = b * PI / 180.0;
	double C = c * PI / 180.0;

	//라디안으로 원 위의 점 구하기
	double x1 = 40 * cos(A);   
	double y1 = 40 * sin(A);
	double x2 = 40 * cos(B);
	double y2 = 40 * sin(B);
	double x3 = 40 * cos(C);
	double y3 = 40 * sin(C);

	//점 사이의 거리 구하기(삼각형PQR)
	double p = sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));   
	double q = sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
	double r = sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));

	//각도 구하기(라디안)
	double P = acos((p * p - q * q - r * r) / (-2 * q * r));   
	double Q = acos((q * q - p * p - r * r) / (-2 * p * r));
	double R = acos((r * r - p * p - q * q) / (-2 * p * q));

	//라디안을 각도로 변환하기
	double ans_P = P * 180.0 / PI;
	double ans_Q = Q * 180.0 / PI;
	double ans_R = R * 180.0 / PI;

	cout << "3 angles of triangle are " << ans_P << " " << ans_Q << " " << ans_R << endl;

	return 0;
}