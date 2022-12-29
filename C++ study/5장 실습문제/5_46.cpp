#include<iostream>
using namespace std;

int main()
{//비트 연산
	cout << "Enter an integer : ";
	short i;
	cin >> i;
	
	int result;
	cout << "The bits are ";

	for (int j = 15; j >= 0; --j)
	{
		result = i >> j & 1;
		cout << result;
	}
	

	return 0;
}