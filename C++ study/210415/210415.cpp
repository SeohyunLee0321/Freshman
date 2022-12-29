#include<iostream>
using namespace std;

int main()
{
	//사용자에게 신고 지위를 입력하도록 함
	cout << "(0-single filer, 1-married jointly, "
		<< "or qualifying widow(er), " << endl
		<< "2-married separately, 3-head of household)" << endl
		<< "Enter the filing status: ";

	int status;
	cin >> status;

	//과세 소득을 입력하도록 함
	cout << "Enter the taxable income: ";
	double income;
	cin >> income;

	//세금 계산
	double tax = 0;

	switch (status)
	{
	case 0: //1인 과세 세금
		if (income <= 8350)
			tax = income * 0.10;
		else if (income <= 33950)
			tax = 8350 * 0.10 + (income - 8350) * 0.15;
		else if (income <= 82250)
			tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (income - 33950) * 0.25;
		else if (income <= 171550)
			tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (82250 - 33950) * 0.25 + (income - 82250) * 0.28;
		else if (income <= 372950)
			tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (82250 - 33950) * 0.25 + (171550 - 82250) * 0.28 +
			(income - 171550) * 0.33;
		else
			tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (82250 - 33950) * 0.25 + (171550 - 82250) * 0.28 +
			(372950 - 171550) * 0.33 + (income - 372950) * 0.35;
		break;

	case 1: //부부합산 과세 세금
		if (income <= 16700)
			tax = income * 0.10;
		else if (income <= 67900)
			tax = 16700 * 0.10 + (income - 16700) * 0.15;
		else if (income <= 137050)
			tax = 16700 * 0.10 + (67900 - 16700) * 0.15 + (income - 67900) * 0.25;
		else if (income <= 208850)
			tax = 16700 * 0.10 + (67900 - 16700) * 0.15 + (137050 - 67900) * 0.25 + (income - 137050) * 0.28;
		else if (income <= 372950)
			tax = 16700 * 0.10 + (67900 - 16700) * 0.15 + (137050 - 67900) * 0.25 + (208850 - 137050) * 0.28 +
			(income - 208850) * 0.33;
		else
			tax = 16700 * 0.10 + (67900 - 16700) * 0.15 + (137050 - 67900) * 0.25 + (208850 - 137050) * 0.28 +
			(372950 - 208850) * 0.33 + (income - 372950) * 0.35;
		break;

	case 2: //부부별도 과세 세금
		if (income <= 8350)
			tax = income * 0.10;
		else if (income <= 33950)
			tax = 8350 * 0.10 + (income - 8350) * 0.15;
		else if (income <= 68525)
			tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (income - 33950) * 0.25;
		else if (income <= 104425)
			tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (68525 - 33950) * 0.25 + (income - 68525) * 0.28;
		else if (income <= 186475)
			tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (68525 - 33950) * 0.25 + (104425 - 68525) * 0.28 +
			(income - 104425) * 0.33;
		else
			tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (68525 - 33950) * 0.25 + (104425 - 68525) * 0.28 +
			(186475 - 104425) * 0.33 + (income - 186475) * 0.35;
		break;

	case 3: //가장 과세 세금
		if (income <= 11950)
			tax = income * 0.10;
		else if (income <= 45500)
			tax = 11950 * 0.10 + (income - 11950) * 0.15;
		else if (income <= 117450)
			tax = 11950 * 0.10 + (45500 - 11950) * 0.15 + (income - 45500) * 0.25;
		else if (income <= 190200)
			tax = 11950 * 0.10 + (45500 - 11950) * 0.15 + (117450 - 45500) * 0.25 + (income - 117450) * 0.28;
		else if (income <= 372950)
			tax = 11950 * 0.10 + (45500 - 11950) * 0.15 + (117450 - 45500) * 0.25 + (190200 - 117450) * 0.28 +
			(income - 190200) * 0.33;
		else
			tax = 11950 * 0.10 + (45500 - 11950) * 0.15 + (117450 - 45500) * 0.25 + (190200 - 117450) * 0.28 +
			(372950 - 190200) * 0.33 + (income - 372950) * 0.35;
		break;

	default: cout << "Errors : Invalid Status" << endl;
	}

	//결과 화면 출력
	cout << "Tax is " << static_cast<int>(tax * 100) / 100.0 << endl;

	return 0;
}