#include<iostream>
#include<algorithm>
using namespace std;

int main()
{
	//�� ���� �Է�
	int n1, n2;
	
	cout << "Enter two integers : ";
	cin >> n1 >> n2;

	//�� �� �� �� ���� �� d ���ϱ�
	int range = min(n1, n2);

	//�ִ����� ���ϱ�
	int gcd;
	
	for (int d = range; d >= 1; d--)
	{
		if (n1 % d == 0 && n2 % d == 0)
		{
			gcd = d;
			break;
		}
	}

	cout << "The greatest common divisor for " << n1 << " and " << n2 << " is " << gcd << endl;

	return 0;
}