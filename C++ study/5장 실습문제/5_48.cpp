#include<iostream>
#include<string>
using namespace std;

int main()
{//���ڿ� �� �빮�� ����
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