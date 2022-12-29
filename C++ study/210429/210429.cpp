#include<iostream>
using namespace std;

int main()
{
	int month = 0; //결정한 달
	char answer;

	//세트1에 대해 사용자에게 묻기
	cout << "Is your month of birth in Set1?" << endl;
	cout << " 1  3  5  7  9 11 13 " << endl;
	cout << "Enter N/n for No and Y/y for Yes : ";
	cin >> answer;

	if (answer == 'Y' || answer == 'y')
		month += 1;

	//세트2에 대해 사용자에게 묻기
	cout << "Is your month of birth in Set2?" << endl;
	cout << " 2  3  6  7 10 11 " << endl;
	cout << "Enter N/n for No and Y/y for Yes : ";
	cin >> answer;

	if (answer == 'Y' || answer == 'y')
		month += 2;

	//세트3에 대해 사용자에게 묻기
	cout << "Is your month of birth in Set3?" << endl;
	cout << " 4  5  6  7 12 " << endl;
	cout << "Enter N/n for No and Y/y for Yes : ";
	cin >> answer;

	if (answer == 'Y' || answer == 'y')
		month += 4;
	
	//세트4에 대해 사용자에게 묻기
	cout << "Is your month of birth in Set3?" << endl;
	cout << " 8  9 10 11 12 " << endl;
	cout << "Enter N/n for No and Y/y for Yes : ";
	cin >> answer;

	if (answer == 'Y' || answer == 'y')
		month += 8;

	cout << endl << "Your month of birth is " << month << endl;

	return 0;
}