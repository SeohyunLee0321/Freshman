#include<iostream>
#include<cmath>
#include<iomanip>
#include<ctime>
using namespace std;

int main()
{
	//0~360 ���� ����
	srand(time(0));            
	double a = rand() % 360;
	double b = rand() % 360;
	double c = rand() % 360;
		
	//�������� ����
	const double PI = 3.14159; 
	double A = a * PI / 180.0;
	double B = b * PI / 180.0;
	double C = c * PI / 180.0;

	//�������� �� ���� �� ���ϱ�
	double x1 = 40 * cos(A);   
	double y1 = 40 * sin(A);
	double x2 = 40 * cos(B);
	double y2 = 40 * sin(B);
	double x3 = 40 * cos(C);
	double y3 = 40 * sin(C);

	//�� ������ �Ÿ� ���ϱ�(�ﰢ��PQR)
	double p = sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));   
	double q = sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
	double r = sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));

	//���� ���ϱ�(����)
	double P = acos((p * p - q * q - r * r) / (-2 * q * r));   
	double Q = acos((q * q - p * p - r * r) / (-2 * p * r));
	double R = acos((r * r - p * p - q * q) / (-2 * p * q));

	//������ ������ ��ȯ�ϱ�
	double ans_P = P * 180.0 / PI;
	double ans_Q = Q * 180.0 / PI;
	double ans_R = R * 180.0 / PI;

	cout << "3 angles of triangle are " << ans_P << " " << ans_Q << " " << ans_R << endl;

	return 0;
}