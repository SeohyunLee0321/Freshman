#include<iostream>
#include<fstream>
using namespace std;

int main()
{//���� �� ���� ���� ����
	ifstream input("countletters.txt");

	double sum = 0;
	char letters;
	while (input.eof())
	{
		input >> letters;
		sum++;
	}
	input.close();

	cout << "The count of letters are " << sum;

	return 0;
}