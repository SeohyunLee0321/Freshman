#include<iostream>
#include<ctime>
#include<cstdlib>
using namespace std;

int main()
{//���� ������
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
//������ �𸣰����� 15��° �ٿ��� ���� �߻��̶�� ������ ������ ���