#include<iostream>
#include<iomanip>
using namespace std;

int main()
{
	/*cout << "패턴 A\n\n";

	for (int i = 1; i <= 6; i++)
	{
		for (int j = 1; j <= i; j++)
		{
			cout << j << " ";
		}
		cout << endl;
	}

	cout << "패턴 B\n\n";

	for (int i = 6; i >= 1; i--)
	{
		for (int j = 1; j <= i; j++)
		{
			cout << j << " ";
		}
		cout << endl;
	}

	cout << "패턴 C\n\n";

	for (int i = 1; i <= 6; i++)
	{
		for (int j = i; j >= 1; j--)
		{
			cout << j << " ";
		}
		cout << endl;
	}*/

	cout << "패턴 D\n\n";

	for (int i = 6; i >= 1; i--)
	{
		for (int j = i; j >= 1; j--)
		{
			cout << right << j << " ";
		}
		cout << endl;
	}
	return 0;
}