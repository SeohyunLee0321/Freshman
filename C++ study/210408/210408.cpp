#include <iostream>
using namespace std;

int main()
{
//LIST 3.8
	
	//금액을 입력
	cout << "Enter an amount in double, for example 11.56 : ";
	double amount;
	cin >> amount;

	int RemainingAmount = static_cast<int>(amount * 100);

	//1달러의 수를 계산
	int NumofDollars = RemainingAmount / 100;
	RemainingAmount = RemainingAmount % 100;

	//남은 금액에서 쿼터 계산
	int NumofQuarters = RemainingAmount / 25;
	RemainingAmount = RemainingAmount % 25;

	//남은 금액에서 다임 계산
	int NumofDimes = RemainingAmount / 10;
	RemainingAmount = RemainingAmount % 10;

	//남은 금액에서 니켈 계산
	int NumofNickels = RemainingAmount / 5;
	RemainingAmount = RemainingAmount % 5;

	//남은 금액에서 페니 계산
	int NumofPennies = RemainingAmount;

	//결과 화면 표시
	cout << "Your amount " << amount << " consists of " << endl;
	
	if (NumofDollars < 1)
		cout << "";
	else if (NumofDollars < 2)
		cout << "1 dollar ";
	else
		cout << NumofDollars << " dollars ";        //달러 출력

	if (NumofQuarters < 1)
		cout << "";
	else if (NumofQuarters < 2)
		cout << "1 quarter ";
	else
		cout << NumofQuarters << " quarters ";      //쿼터 출력

	if (NumofDimes < 1)
		cout << "";
	else if (NumofDimes < 2)
		cout << "1 dime ";
	else
		cout << NumofDimes << " dimes ";            //다임 출력

	if (NumofNickels < 1)
		cout << "";
	else if (NumofNickels < 2)
		cout << "1 nickel ";
	else
		cout << NumofNickels << " nickels ";        //니켈 출력

	if (NumofPennies < 1)
		cout << "";
	else if (NumofPennies < 2)
		cout << "1 penny ";
	else
		cout << NumofPennies << " pennies ";        //페니 출력


	
//LIST 2.13

	cout << endl << endl << endl << "월 저축금액을 입력하세요 : ";
	double MonthlySavingAmount; //월 저축금액
	cin >> MonthlySavingAmount;

	double MonthlyInterestRate = 0.05 / 12; //월 이자율
	double TotalBalance; //총 잔액
	double AmountIcrement_Month = MonthlySavingAmount * (1 + MonthlyInterestRate); //월 저축금액 * (1 + 월 이자율)
	double RateofIncrease_Month = (1 + MonthlyInterestRate); //한 달간 증가율

	//첫번째 달 잔액
	double Balance_1st = AmountIcrement_Month;
	TotalBalance = Balance_1st;

	//두번째 달 잔액
	double Balance_2nd = TotalBalance * RateofIncrease_Month + AmountIcrement_Month;
	TotalBalance = Balance_2nd;

	//세번째 달 잔액
	double Balance_3rd = TotalBalance * RateofIncrease_Month + AmountIcrement_Month;
	TotalBalance = Balance_3rd;

	//네번째 달 잔액
	double Balance_4th = TotalBalance * RateofIncrease_Month + AmountIcrement_Month;
	TotalBalance = Balance_4th;

	//다섯번째 달 잔액
	double Balance_5th = TotalBalance * RateofIncrease_Month + AmountIcrement_Month;
	TotalBalance = Balance_5th;

	//여섯번째 달 잔액
	double Balance_6th = TotalBalance * RateofIncrease_Month + AmountIcrement_Month;
	TotalBalance = Balance_6th;

	//결과 화면 출력
	cout << "1달 후 금액" << Balance_1st << endl;
	cout << "2달 후 금액" << Balance_2nd << endl;
	cout << "3달 후 금액" << Balance_3rd << endl;
	cout << "4달 후 금액" << Balance_4th << endl;
	cout << "5달 후 금액" << Balance_5th << endl;
	cout << "6달 후 금액" << Balance_6th << endl;
}