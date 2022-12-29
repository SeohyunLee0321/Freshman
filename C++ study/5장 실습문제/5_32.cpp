#include<iostream>
using namespace std;

int main()
{//복리계산
	double monthly_input;
	cout << "Enter monthly input : ";
	cin >> monthly_input;

	double annual_InterestRate;
	cout << "Enter annual interest rate : ";
	cin >> annual_InterestRate;
	double monthly_InterestRate = annual_InterestRate / 1200.0 + 1; //월 이자율

	int month;
	cout << "Enter month : ";
	cin >> month;
    
	double totalAmount = 0;
	for (int i = 1; i <= month; i++)
	{
	    totalAmount = (monthly_input + totalAmount) * monthly_InterestRate;

		cout << "After " << i << " months total amount will be " << totalAmount << endl;
	}
	return 0;
}