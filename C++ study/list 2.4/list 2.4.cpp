#include <iostream>
using namespace std;

int main()
{
	const double PI = 3.14159;

	//1�ܰ� : ������ �б�
	double radius;
	cout << "�������� �Է��ϼ���: ";
	cin >> radius;

	//2�ܰ� : ���
	double circle_area = radius * radius * PI;                //���� ����
	double circumference = radius * 2 * PI;                   //���� �ѷ�
	double area_circumscribed_square = 4 * radius * radius;   //���� �簢�� ����
	double area_inscribed_square = 2 * radius * radius;       //���� �簢�� ����

	//3�ܰ� : ��� ���
	cout << "���� ����: ";
	cout << circle_area << endl;
	cout << "���� �ѷ�: ";
	cout << circumference << endl;
	cout << "���� �簢���� ����: ";
	cout << area_circumscribed_square << endl;
	cout << "���� �簢���� ����: ";
	cout << area_inscribed_square << endl;

	return 0;
}