#include<iostream>
#include<iomanip>
using namespace std;

int main()
{
	int count = 1;

	cout << left << setw(10) << "Miles" << "Kilometers\n";

	while (count < 10)
	{
		double kilometers = count * 1.609;

		cout << left << setw(10) << count << kilometers << endl;
		count++;
	}
	
	return 0;
}