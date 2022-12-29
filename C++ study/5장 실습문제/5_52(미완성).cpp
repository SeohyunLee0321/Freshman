#include <string>
#include <iostream>

using namespace std;

int main()
{//홀수 인덱스 출력
	string s;
	cout << "Enter a string : ";
	cin >> s;

	int count = 0;
	for (int i = 0; i < s.length(); i++)
	{
		char result = s.at(i);
		if (s.at(i) == ' ')
		{
			count = 0;  //띄어쓰기에서 count를 0으로 초기화하는 것 까지 생각했는데 코딩을 하는 과정에서 막힘 continue
		}
		else
			if()
	}
	return 0;
}