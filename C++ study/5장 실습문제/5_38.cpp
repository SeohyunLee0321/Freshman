#include<iostream>
#include<iomanip>
using namespace std;

int main()
{//ISBN-10검사
	for (int i = 1; i <= 10; i++)
	{
		int j;
		cout << "Enter the first 9 digits of an ISBN as integer : ";
		cin >> j;

		int d1 = j / 100000000;
		int d2 = (j / 10000000) % 10;
		int d3 = (j / 1000000) % 10;
		int d4 = (j / 100000) % 10;
		int d5 = (j / 10000) % 10;
		int d6 = (j / 1000) % 10;
		int d7 = (j / 100) % 10;
		int d8 = (j / 10) % 10;
		int d9 = j % 10;
		int d10 = (d1 * 1 + d2 * 2 + d3 * 3 + d4 * 4 + d5 * 5 + d6 * 6 + d7 * 7 + d8 * 8 + d9 * 9) % 11;

		if (d10 == 10)
			cout << d1 << d2 << d3 << d4 << d5 << d6 << d7 << d8 << d9 << "X\n";
		else
			cout << d1 << d2 << d3 << d4 << d5 << d6 << d7 << d8 << d9 << d10 << endl;
	}
	return 0;
}//문자열로 받아서 s.at 써도될듯