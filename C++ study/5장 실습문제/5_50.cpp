#include <iostream>
using namespace std;

int main() 
{//문자열 역순 출력
	int a = 0;
	char num[100], temp[4];

	cout << "문자열 입력:";
	cin >> num;

	for (int i = 0; num[i] != 0; i++) 
	{
		a++;
	}
	a -= 1;

	for (int i = 0; a > 0; a--, i++) 
	{
		if (a - i == 1 || a == i)
			break;
		*temp = num[a];
		num[a] = num[i];
		num[i] = *temp;
	}
	cout << num;

	return 0;
}