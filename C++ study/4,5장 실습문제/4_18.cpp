#include<iostream>
#include<ctime>
using namespace std;

int main()
{
	srand(time(0));
	int char_a = 65 + rand() % 26;
	int char_b = 65 + rand() % 26;
	int char_c = 65 + rand() % 26;

	char char_A = static_cast<char>(char_a);
	char char_B = static_cast<char>(char_b);
	char char_C = static_cast<char>(char_c);

	cout << "3 random uppercase letters are " << char_A << char_B << char_C << endl;

	return 0;
}