#include<iostream>
#include<ctime>
#include<cstdlib>
using namespace std;

int main()
{//동전 던지기
	int front = 0;
	int back = 0;
	int coin;
    srand(time(0));
	
	for (int i = 1; i <= 1000000; i++)
	{
		
		 coin = rand() % 2;

		if (coin == 0)
			front++;
		if (coin == 1)
			back++;
		
	}
	cout << "Coin faced front " << front << " times, and faced back " << back << " times";

	return 0;
}
//이유는 모르겠지만 15번째 줄에서 예외 발생이라는 이유로 오류가 뜬다