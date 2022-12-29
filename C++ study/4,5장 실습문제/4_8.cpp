#include<iostream>
using namespace std;

int main()
{
	int ascii;
	cout << "Enter an ASCII code between 0 ~ 127 : ";
	cin >> ascii;

	char ascii_char = static_cast<char>(ascii);

	cout << ascii_char << endl;

	return 0;
}