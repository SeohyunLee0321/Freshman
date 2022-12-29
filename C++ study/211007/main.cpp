#include <iostream>
#include "StackOfIntegers.h"
#include <sstream>
using namespace std;

int main()
{
	cout << "Code #1 : " << endl;
	StackOfStrings stack1;

	for (int i = 0; i < 10; i++)
		stack1.push(string("One") + to_string(i));		//i¸¦ stringÀ¸·Î ¹Ù²ãÁÜ

	while (!stack1.isEmpty())
		cout << stack1.pop() << endl;

	cout << endl << "Code #2 : " << endl;
	StackOfStrings stack2;
	stringstream ss2;

	for (int i = 0; i < 10; i++)
	{
		ss2 << "Two" << i;
		stack2.push(ss2.str());
		ss2.str("");
	}

	while (!stack2.isEmpty())
		cout << stack2.pop() << endl;

	cout << endl << "Code #3 : " << endl;
	StackOfStrings stack3;
	stringstream ss3;

	for (int i = 0; i < 9; i++)
	{
		ss3 << "Three" << i << " ";
	}
	ss3 << "Three9";

	string elm;
	while (!ss3.eof())
	{
		ss3 >> elm;
		stack3.push(elm);
	}

	while (!stack3.isEmpty())
		cout << stack3.pop() << endl;

	return 0;
}