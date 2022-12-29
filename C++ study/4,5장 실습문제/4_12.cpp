#include<iostream>
#include<cctype>
using namespace std;

int main ()
{
char grade;
cout << "Enter a letter grade : ";
cin >> grade;

if (static_cast<char>(toupper(grade)) == 'A')
cout << "The numeric value for grade " << grade << " is 4" << endl;
if (static_cast<char>(toupper(grade)) == 'B')
cout << "The numeric value for grade " << grade << " is 3" << endl;
if (static_cast<char>(toupper(grade)) == 'C')
cout << "The numeric value for grade " << grade << " is 2" << endl;
if (static_cast<char>(toupper(grade)) == 'D')
cout << "The numeric value for grade " << grade << " is 1" << endl;
if (static_cast<char>(toupper(grade)) == 'F')
cout << "The numeric value for grade " << grade << " is 0" << endl;

return 0;
}