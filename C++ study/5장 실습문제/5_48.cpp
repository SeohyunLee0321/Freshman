#include<iostream>
#include<string>
using namespace std;

int main()
{//문자열 내 대문자 개수
	cout << "Enter a string : ";
	string message;
	cin >> message;

	int length = message.length();

	int num_isupper = 0;
	for (int i = 0; i < length; i++)
	{
		char message_char = message[i];

		if (isupper(message_char))
		{
			num_isupper++;
		}
	}

	cout << "The number of uppercase letters is " << num_isupper;

	return 0;
}