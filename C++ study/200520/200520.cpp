#include<iostream>
#include<iomanip>
using namespace std;

int main()
{
	double sum = 0;
    cout << fixed << setprecision(20);

	double i;

	for (i = 0.01; i <= 1.0; i = i + 0.01)
	{
		cout << "i = " << i << endl;
		sum += i;
		cout << "Partial sum = " << sum << endl << endl;
	}
	
	cout << "\nFinally, i = " << i << endl;
	cout << "The sum is " << sum << endl;

	return 0;
}