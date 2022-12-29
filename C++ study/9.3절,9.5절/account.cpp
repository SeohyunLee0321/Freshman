#include "account.h"

Account::Account()
{
	id = 0;
	balance = 0;
	annualInterestRate = 0;
}

int Account::getId()
{
	return id;
}

double Account::getBalance()
{
	return balance;
}

double Account::getAnnualInterestRate()
{
	return annualInterestRate;
}

void Account::setId(int newId)
{
	id = newId;
}

void Account::setBalance(double newBalance)
{
	balance = newBalance;
}

void Account::setAnnualInterestRate(double newAnnualInterestRate)
{
	annualInterestRate = newAnnualInterestRate;
}

double Account::getMonthlyInterestRate(double annualInterestRate)
{
	return annualInterestRate / 12;
}

double Account::withDraw(double amount)
{
	return balance = balance - amount;
}

double Account::deposit(double amount)
{
	return balance = balance + amount;
}