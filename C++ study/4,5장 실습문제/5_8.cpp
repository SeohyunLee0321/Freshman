#include<iostream>
#include<iomanip>
#include<cmath>
using namespace std;

int main()
{
	int count = 0;

	cout << left << setw(15) << "Number" << "SpuareRoot\n";

	while (count < 20)
	{
		double squareroot = sqrt(count);

		cout << setw(15) << left << count << squareroot << endl;
		count++;
	}

	return 0;
}