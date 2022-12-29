#include<iostream>
#include<ctime>
#include<cstdlib>
using namespace std;

int main()
{
	
	int user_choice;
	int com_choice;
	

	int user_win = 0;
	int com_win = 0;

	

	do
	{
		srand(time(0));
		int com_choice = rand() % 3;
		cout << "scissor (0), rock (1), paper (2) : ";
		cin >> user_choice;
		if (user_choice == com_choice)
		{
			if (user_choice == 0)
				cout << "The computer is scissor. You are scissor too. It is a draw\n";
			if (user_choice == 1)
				cout << "The computer is rock. You are rock too. It is a draw\n";
			if (user_choice == 2)
				cout << "The computer is paper. You are paper too. It is a draw\n";
		}
		else
		{
			if (user_choice == 0 && com_choice == 2)
			{
				cout << "The computer is paper. You are scissor. You won\n";
				user_win++;
			}
			if (user_choice == 1 && com_choice == 0)
			{
				cout << "The computer is scissor. You are rock. You won\n";
				user_win++;
			}
			if (user_choice == 2 && com_choice == 1)
			{
				cout << "The computer is rock. You are paper. You won\n";
				user_win++;
			}
			if (user_choice == 0 && com_choice == 1)
			{
				cout << "The computer is rock. You are scissor. You lost\n";
				com_win++;
			}
			if (user_choice == 1 && com_choice == 2)
			{
				cout << "The computer is paper. You are rock. You lost\n";
				com_win++;
			}
			if (user_choice == 2 && com_choice == 0)
			{
				cout << "The computer is scissor. You are paper. You lost\n";
				com_win++;
			}
		}
	} while (user_win <= 2 || com_win <=2);
	cout << com_win << user_win;
	
	return 0;
}
//¹Ýº¹ÀÌ ¾ÈµÊ