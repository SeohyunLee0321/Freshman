#include<iostream>
#include<string>
using namespace std;

int main()
{
	string message;
	cout << "Enter a message : ";
	cin >> message;

	cout << "Length of the message is " << message.length() << " and the first letter on the message is " 
		 << message.at(0) << endl;

	return 0;
}