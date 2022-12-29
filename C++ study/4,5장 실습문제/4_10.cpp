#include<iostream>
#include<cctype>
using namespace std;

int main()
{
	char letter;
	cout << "Enter a letter : ";
	cin >> letter;

	if (static_cast<char>(toupper(letter)) == 'A' || static_cast<char>(toupper(letter)) == 'E' || 
		static_cast<char>(toupper(letter)) == 'I' || static_cast<char>(toupper(letter)) == 'O' || 
		static_cast<char>(toupper(letter)) == 'U')
		cout << letter << " is a vowel" << endl;
	
	else if (static_cast<int>(letter) >= 65 && static_cast<int>(letter) <= 90)
		cout << letter << " is a consonant" << endl;
	
	else
		cout << letter << " is an invalid input" << endl;

	return 0;
}