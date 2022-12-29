#include<Iostream>
#include<iomanip>
using namespace std;

int main()
{//한줄에 8개의 소수 출력
	const int NUMBER_OF_PRIMES_PER_LINE = 8;
	int count = 0;
	int number = 2;

	cout << "The prime numbers between 2 and 1000 are \n";

	while (number >=2 && number <= 1000)
	{
		bool isPrime = true;

		for (int divisor = 2; divisor <= number / 2; divisor++)
		{
			if (number % divisor == 0)
			{
				isPrime = false;
				break;
			}
		}

		if (isPrime)
		{
			count++;

			if (count % NUMBER_OF_PRIMES_PER_LINE == 0)
				cout << setw(4) << number << endl;
			else
				cout << setw(4) << number;
		}

		number++;
	}

	return 0;
}