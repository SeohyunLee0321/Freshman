#include <iostream>
#include "Date.h"
#include "EvenNumber.h"
using namespace std;

int main()
{
	cout << "---------------- 9.8 ----------------" << endl;
	Date d1, d2(561555550);
	cout << "d1 year : " << d1.getYear() << endl;
	cout << "d1 month : " << d1.getMonth() << endl;
	cout << "d1 day : " << d1.getDay() << endl << endl;

	cout << "d2 year : " << d2.getYear() << endl;
	cout << "d2 month : " << d2.getMonth() << endl;
	cout << "d2 day : " << d2.getDay() << endl << endl;

	cout << "---------------- 9.11 ----------------" << endl;
	EvenNumber e(16);
	cout << "Next Even : " << e.getNext() << endl;
	cout << "Previous Even : " << e.getPrevious() << endl;
}