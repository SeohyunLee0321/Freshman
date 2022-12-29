#include<iostream>
#include<algorithm>
using namespace std;

int main()
{
	//두 정수 입력
	int n1, n2;
	
	cout << "Enter two integers : ";
	cin >> n1 >> n2;

	//두 수 중 더 작은 수 d 구하기
	int range = min(n1, n2);

	//최대공약수 구하기
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