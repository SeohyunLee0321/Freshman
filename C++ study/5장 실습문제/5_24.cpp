#include<iostream>
#include<iomanip>
#include<cmath>
using namespace std;

int main()
{//대출 상환 계획
	cout << "Loan Amount : ";
	double loanAmount;
	cin >> loanAmount;

	cout << "Number of Years : ";
	int numberOfYears;
	cin >> numberOfYears;

	cout << "Annual Interest Rate : ";
	double annuaInteretrate;
	cin >> annuaInteretrate;

	double monthlyInterestRate = annuaInteretrate / 1200;

	double monthlyPayment = loanAmount * monthlyInterestRate / (1 - 1.0 / pow(1 + monthlyInterestRate, numberOfYears * 12));
	double totalPayment = monthlyPayment * numberOfYears * 12;

	cout << "Monthly Patment : " << fixed << setprecision(2) << monthlyPayment << endl;
	cout << "Total Payment : " << fixed << setprecision(2) << totalPayment << endl;

	double balance = loanAmount;

	cout << left << setw(15) << "Payment" << setw(15) << "Interest" << setw(15) << "Principal" << setw(15) << "Balance" << endl;

	for (int i = 1; i <= numberOfYears * 12; i++)
	{
		double interest = monthlyInterestRate * balance;
		double principal = monthlyPayment - interest;
		balance = balance - principal;

		cout << left << setw(15) << i << setw(15) << interest << setw(15) << principal << setw(15) << balance << endl;
	}
	return 0;
}