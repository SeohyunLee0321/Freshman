#include <string>
#include <iostream>

using namespace std;

int main()
{//Ȧ�� �ε��� ���
	string s;
	cout << "Enter a string : ";
	cin >> s;

	int count = 0;
	for (int i = 0; i < s.length(); i++)
	{
		char result = s.at(i);
		if (s.at(i) == ' ')
		{
			count = 0;  //���⿡�� count�� 0���� �ʱ�ȭ�ϴ� �� ���� �����ߴµ� �ڵ��� �ϴ� �������� ���� continue
		}
		else
			if()
	}
	return 0;
}