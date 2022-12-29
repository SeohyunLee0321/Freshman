#include<iostream>
using namespace std;

// swap two variables using pass-by-value
void swap1(int n1, int n2)
{
	int temp = n1;
	n1 = n2;
	n2 = temp;
}

// swap two variables using pass-by-reference
void swap2(int& n1, int& n2)
{
	int temp = n1;
	n1 = n2;
	n2 = temp;
}

// pass two pointers by value
void swap3c(int* q1, int* q2)
{
	int temp = *q1;
	*q1 = *q2;
	*q2 = temp;
}

// pass two pointers by value
void swap3p(int* q1, int* q2)
{
	// swap pointers
	int* temp = q1;
	q1 = q2;
	q2 = temp;
}

// pass two pointers by reference
void swap4c(int* &q1, int* &q2)
{
	// swap contents pointed by pointers
	int temp = *q1;
	*q1 = *q2;
	*q2 = temp;
}

// pass two pointers by reference
void swap4p(int* &q1, int* &q2)
{
	// swap pointers
	int* temp = q1;
	q1 = q2;
	q2 = temp;
}

int main()
{
	// swap1
	int num1 = 1;
	int num2 = 2;

	cout << "Before invoking the swap1 function, num1 is " << num1 
		<< " and num2 is " << num2 << endl;

	// invoke the swap function to attempt to swap two variables
	swap1(num1, num2);

	cout << "After invoking the swap1 function, num1 is " << num1 
		<< " and num2 is " << num2 << endl << endl;

	// swap2
	num1 = 1;
	num2 = 2;

	cout << "Before invoking the swap2 function, num1 is " << num1 
		<< " and num2 is " << num2 << endl;

	// invoke the swap function to attempt to swap two variables
	swap2(num1, num2);

	cout << "After invoking the swap2 function, num1 is " << num1 
		<< " and num2 is " << num2 << endl << endl;

	// swap3c (swap contents)
	num1 = 1;
	num2 = 2;
	int* p1 = &num1;
	int* p2 = &num2;

	cout << "Before invoking the swap3c function, num1 is " << num1 
		<< " and num2 is " << num2 << endl;
	cout << "Before invoking the swap3c function, p1 is " << p1 
		<< " and p2 is " << p2 << endl;

	// invoke the swap function to attempt to swap two variables
	swap3c(p1, p2);

	cout << "After invoking the swap3c function, num1 is " << num1 
		<< " and num2 is " << num2 << endl;
	cout << "After invoking the swap3c function, p1 is " << p1 
		<< " and p2 is " << p2 << endl << endl;

	// swap3p (swap contents)
	num1 = 1;
	num2 = 2;
	p1 = &num1;
	p2 = &num2;

	cout << "Before invoking the swap3p function, num1 is " << num1 
		<< " and num2 is " << num2 << endl;
	cout << "Before invoking the swap3p function, p1 is " << p1 
		<< " and p2 is " << p2 << endl;

	// invoke the swap function to attempt to swap two variables
	swap3p(p1, p2);

	cout << "After invoking the swap3p function, num1 is " << num1 
		<< " and num2 is " << num2 << endl;
	cout << "After invoking the swap3p function, p1 is " << p1 
		<< " and p2 is " << p2 << endl << endl;

	// swap4c (swap contents)
	num1 = 1;
	num2 = 2;
	int* p3 = &num1;
	int* p4 = &num2;

	cout << "Before invoking the swap4c function, num1 is " << num1 
		<< " and num2 is " << num2 << endl;
	cout << "Before invoking the swap4c function, p3 is " << p3 
		<< " and p4 is " << p4 << endl;
	cout << "Before invoking the swap4c function, *p3 is " << *p3 
		<< " and *p4 is " << *p4 << endl;

	// invoke the swap function to attempt to swap two variables
	swap4c(p3, p4);

	cout << "After invoking the swap4c function, num1 is " << num1 
		<< " and num2 is " << num2 << endl;
	cout << "After invoking the swap4c function, p3 is " << p3 
		<< " and p4 is " << p4 << endl;
	cout << "After invoking the swap4c function, *p3 is " << *p3 
		<< " and *p4 is " << *p4 << endl << endl;

	// swap4p (swap pointers)
	num1 = 1;
	num2 = 2;
	p3 = &num1;
	p4 = &num2;

	cout << "Before invoking the swap4p function, num1 is " << num1 
		<< " and num2 is " << num2 << endl;
	cout << "Before invoking the swap4p function, p3 is " << p3 
		<< " and p4 is " << p4 << endl;
	cout << "Before invoking the swap4p function, *p3 is " << *p3 
		<< " and *p4 is " << *p4 << endl;

	// invoke the swap function to attempt to swap two variables
	swap4p(p3, p4);

	cout << "After invoking the swap4p function, num1 is " << num1 
		<< " and num2 is " << num2 << endl;
	cout << "After invoking the swap4p function, p3 is " << p3 
		<< " and p4 is " << p4 << endl;
	cout << "After invoking the swap4p function, *p3 is " << *p3 
		<< " and *p4 is " << *p4 << endl << endl;

	return 0;
}