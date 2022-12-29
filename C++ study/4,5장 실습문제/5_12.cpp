#include<iostream>
using namespace std;

int main()
{
	int a = 100;
	int b = 0;

	while (a < 1000)
	{
		a++;

		if (a % 5 == 0 && a % 6 == 0)
		{
			cout << a << " ";

			b++;
			
			if (b >= 10)
			{
				cout << "\n";
				b = 0;
			}
		}
	}
	return 0;
}