#include <iostream>
using namespace std;

int main()
{
//LIST 3.8
	
	//�ݾ��� �Է�
	cout << "Enter an amount in double, for example 11.56 : ";
	double amount;
	cin >> amount;

	int RemainingAmount = static_cast<int>(amount * 100);

	//1�޷��� ���� ���
	int NumofDollars = RemainingAmount / 100;
	RemainingAmount = RemainingAmount % 100;

	//���� �ݾ׿��� ���� ���
	int NumofQuarters = RemainingAmount / 25;
	RemainingAmount = RemainingAmount % 25;

	//���� �ݾ׿��� ���� ���
	int NumofDimes = RemainingAmount / 10;
	RemainingAmount = RemainingAmount % 10;

	//���� �ݾ׿��� ���� ���
	int NumofNickels = RemainingAmount / 5;
	RemainingAmount = RemainingAmount % 5;

	//���� �ݾ׿��� ��� ���
	int NumofPennies = RemainingAmount;

	//��� ȭ�� ǥ��
	cout << "Your amount " << amount << " consists of " << endl;
	
	if (NumofDollars < 1)
		cout << "";
	else if (NumofDollars < 2)
		cout << "1 dollar ";
	else
		cout << NumofDollars << " dollars ";        //�޷� ���

	if (NumofQuarters < 1)
		cout << "";
	else if (NumofQuarters < 2)
		cout << "1 quarter ";
	else
		cout << NumofQuarters << " quarters ";      //���� ���

	if (NumofDimes < 1)
		cout << "";
	else if (NumofDimes < 2)
		cout << "1 dime ";
	else
		cout << NumofDimes << " dimes ";            //���� ���

	if (NumofNickels < 1)
		cout << "";
	else if (NumofNickels < 2)
		cout << "1 nickel ";
	else
		cout << NumofNickels << " nickels ";        //���� ���

	if (NumofPennies < 1)
		cout << "";
	else if (NumofPennies < 2)
		cout << "1 penny ";
	else
		cout << NumofPennies << " pennies ";        //��� ���


	
//LIST 2.13

	cout << endl << endl << endl << "�� ����ݾ��� �Է��ϼ��� : ";
	double MonthlySavingAmount; //�� ����ݾ�
	cin >> MonthlySavingAmount;

	double MonthlyInterestRate = 0.05 / 12; //�� ������
	double TotalBalance; //�� �ܾ�
	double AmountIcrement_Month = MonthlySavingAmount * (1 + MonthlyInterestRate); //�� ����ݾ� * (1 + �� ������)
	double RateofIncrease_Month = (1 + MonthlyInterestRate); //�� �ް� ������

	//ù��° �� �ܾ�
	double Balance_1st = AmountIcrement_Month;
	TotalBalance = Balance_1st;

	//�ι�° �� �ܾ�
	double Balance_2nd = TotalBalance * RateofIncrease_Month + AmountIcrement_Month;
	TotalBalance = Balance_2nd;

	//����° �� �ܾ�
	double Balance_3rd = TotalBalance * RateofIncrease_Month + AmountIcrement_Month;
	TotalBalance = Balance_3rd;

	//�׹�° �� �ܾ�
	double Balance_4th = TotalBalance * RateofIncrease_Month + AmountIcrement_Month;
	TotalBalance = Balance_4th;

	//�ټ���° �� �ܾ�
	double Balance_5th = TotalBalance * RateofIncrease_Month + AmountIcrement_Month;
	TotalBalance = Balance_5th;

	//������° �� �ܾ�
	double Balance_6th = TotalBalance * RateofIncrease_Month + AmountIcrement_Month;
	TotalBalance = Balance_6th;

	//��� ȭ�� ���
	cout << "1�� �� �ݾ�" << Balance_1st << endl;
	cout << "2�� �� �ݾ�" << Balance_2nd << endl;
	cout << "3�� �� �ݾ�" << Balance_3rd << endl;
	cout << "4�� �� �ݾ�" << Balance_4th << endl;
	cout << "5�� �� �ݾ�" << Balance_5th << endl;
	cout << "6�� �� �ݾ�" << Balance_6th << endl;
}