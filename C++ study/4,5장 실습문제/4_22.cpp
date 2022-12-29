#include<iostream>
#include<iomanip>
#include<string>
using namespace std;

int main()
{
    string name;
    cout << "Enter employee's name : ";
    cin >> name;

    double hours_worked;
    cout << "Enter number of hours worked in a week : ";
    cin >> hours_worked;

    double hourly_payrate;
    cout << "Enter hourly pay rate : ";
    cin >> hourly_payrate;

    double federal_tax;
    cout << "Enter federal tax withholing rate : ";
    cin >> federal_tax;

    double state_tax;
    cout << "Enter state tax withholding rate : ";
    cin >> state_tax;

    cout << "Employee name : " << name;
 
    cout << "Hours worked : " << fixed << setprecision(1) << hours_worked;

    cout << "Pay rate : " << hourly_payrate;

    cout << "Gross pay : " << hourly_payrate * hours_worked;
    double gross_pay = hourly_payrate * hours_worked;

    cout << "Deductions : " << endl
         << "Federal Withholding (" << fixed << setprecision(1) << 100.0 * federal_tax << ")" << gross_pay * 20.0 / 100.0 << endl
         << "State Withholding (" << fixed << setprecision(2) << 100.0 * state_tax << ")" << gross_pay * 9.0 / 100.0 << endl;
    double federal_withholding = gross_pay * 20.0 / 100.0;
    double state_withholding = gross_pay * 9.0 / 100.0;

    cout << "Total Deduction : " << federal_withholding + state_withholding;

    return 0;
}