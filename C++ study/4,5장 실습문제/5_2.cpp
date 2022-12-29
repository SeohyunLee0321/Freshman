#include<iostream>
#include<ctime>
using namespace std;

int main()
{
	int correctCount = 0;
	int count = 0;
	long startTime = time(0);
	const int MUMBER_OF_QUESTIONS = 10;

	srand(time(0));

	while (count < MUMBER_OF_QUESTIONS)
	{
		int number1 = rand() % 10;
		int number2 = rand() % 10;

		if (number1 < number2)
		{
			int temp = number1;
			number1 = number2;
			number2 = temp;
		}
		cout << "What is " << number1 << " - " << number2 << "? ";
		int answer;
		cin >> answer;

		if (number1 - number2 == answer)
		{
			cout << "You are correct!\n";
			correctCount++;
		}
		else
			cout << "Your answer is wrong.\n" << number1 << " - " <<
			number2 << " shold be " << (number1 - number2) << endl;

		count++;
	}

	long endTime = time(0);
	long testTime = endTime - startTime;

	cout << "Correct count is " << correctCount << "\nTest time is "
		<< testTime << " seconds\n";

	return 0;
}