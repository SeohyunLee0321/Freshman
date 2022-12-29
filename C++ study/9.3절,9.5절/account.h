#ifndef ACOOUNT_H
#define ACCOUNT_H

class Account{
public:
	Account();
	int getId();
	double getBalance();
	double getAnnualInterestRate();
	void setId(int);
	void setBalance(double);
	void setAnnualInterestRate(double);
	double getMonthlyInterestRate(double);
	double withDraw(double);
	double deposit(double);
private:
	int id;
	double balance;
	double annualInterestRate;
};
#endif