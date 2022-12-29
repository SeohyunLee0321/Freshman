#include<iostream>
using namespace std;

int main()
{//급수의 합
	float i = 0;
	float sum = 0;

	do
	{
		i++;
        
		sum += (i *  2 - 1) / (i * 2 + 1);
	} while (i < 49);
	cout << sum;

	return 0;
}