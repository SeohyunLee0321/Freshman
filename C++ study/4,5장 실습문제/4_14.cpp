#include<iostream>
using namespace std;

int main()
{
	int demical_value;
	cout << "Enter a demical value (0 to 15) : ";
	cin >> demical_value;

	if (demical_value <= 0 && demical_value <= 9)
		cout << "The hex value is " << demical_value << endl;
	if (demical_value == 10)
		cout << "The hex value is A" << endl;
	if (demical_value == 11)
		cout << "The hex value is B" << endl;
	if (demical_value == 12)
		cout << "The hex value is C" << endl;
	if (demical_value == 13)
		cout << "The hex value is D" << endl;
	if (demical_value == 14)
		cout << "The hex value is E" << endl;
	if (demical_value == 15)
		cout << "The hex value is F" << endl;
	else
		cout << demical_value << "is an invalid input" << endl;

	return 0;
}