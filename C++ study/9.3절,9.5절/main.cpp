#include <iostream>
#include "account.h"
#include "time.h"
#include <ctime>
using namespace std;

int main()
{
	Account Account;
	Account.setId(1122);
	Account.setBalance(20000);
	Account.setAnnualInterestRate(0.045);
	Account.withDraw(2500);
	Account.deposit(3000);
	double Account_MIR_state = Account.getMonthlyInterestRate(0.045) * 100;

	cout << "<9.3절>" << endl;
	cout << Account.getId()<<"의 잔액: $" << Account.getBalance()<< "   " << "월 이자: " << Account_MIR_state << "%"<<endl;
	cout << endl;
	cout << "<9.5절>" << endl;

    Time Time1;
	Time Time2(555550);
	
	cout << "현재시각: " << Time1.getHour()-3 << "시 " << Time1.getMinute() << "분 " << Time1.getSecond() << "초" << endl;
	cout << "1970년 1월 1일 자정으로부터 경과된 시간이 555550일때의 시각: " << Time2.getHour() << "시 " << Time2.getMinute() << "분 " << Time2.getSecond() << "초" << endl;
	return 0;
}