#include<iostream>
#include<ctime>
#include<cstdlib>
#include<iomanip>
using namespace std;

int main()
{
	//문제1

	int correctCount = 0;
	int count = 0;
	long startTime = time(0);
	const int NUMBER_OF_QUESTIONS = 5;

	srand(time(0));

	char continueLoop = 'Y';
	while (continueLoop == 'Y')
	{
		while (count < NUMBER_OF_QUESTIONS)
		{
			int number1 = rand() % 10;
			int number2 = rand() % 10;

			if (number1 < number2)
			{
				int temp = number1;
				number1 = number2;
				number2 = temp;
			}
			cout << "What is " << number1 << " _ " << number2 << "? ";
			int answer;
			cin >> answer;

			if (number1 - number2 == answer)
			{
				cout << "You are correct!\n";
				correctCount++;
			}
			else
				cout << "Your answer is wrong.\n" << number1 << " - "
				<< number2 << " should be " << (number1 - number2) << endl;

			count++;
		}
		count = 0;

		cout << "Enter Y to continue and N to quit : ";
		cin >> continueLoop;
	}
	long endTime = time(0);
	long testTime = endTime - startTime;

	cout << "Correct count is " << correctCount << "\nTest time is "
		<< testTime << " seconds\n\n";




	//문제2
	
	cout << left << setw(15) << "Kilograms" << "Pounds\n";

	int kilogram = 1;
	
	while (kilogram < 200)
	{
		double pound = kilogram * 2.2;

		cout << setw(15) << kilogram << fixed << setprecision(1) << pound << endl;

		kilogram += 2;
	}
	return 0;
}