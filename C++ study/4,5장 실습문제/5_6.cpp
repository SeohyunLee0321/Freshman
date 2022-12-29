#include<iostream>
#include<iomanip>
using namespace std;

int main()
{
	int count = 1;

	cout << left << setw(15) <<"Miles" << "Kilometers" << setw(5) << "  |" << setw(15) << "Miles" << "Kilometers\n";

	while (count < 10)
	{
		double kilometers_1 = count * 1.609;
		double kilometers_2 = (15 + count * 5) * 1.609;
		int count_2 = 15 + count * 5;

		cout << setw(15) << left << count << setw(12) << kilometers_1 << "|  " << setw(15) << count_2 << setw(12) << kilometers_2 << endl;
		count++;
	}

	return 0;
}