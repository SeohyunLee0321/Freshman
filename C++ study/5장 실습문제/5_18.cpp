#include<iostream>
using namespace std;

int main()
{
	int i;
	cout << "Enter an integer : ";
	cin >> i;

	int d = 2;
	
	while (d <= i)
	{
		do
		{
			cout << d << " ";
			i = i / d;
		} while (i % d == 0);
		
		d++;
	}
	return 0;
}