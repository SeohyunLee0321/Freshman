#include<iostream>
#include<string>
using namespace std;

int main()
{
	cout << "How many students are there?\n";
	int student_number;
	cin >> student_number;

	int y = 1;
	cout << "Enter student" << y << "'s name and score\n";
	int score_1;
	string name_1;
	cin >> name_1 >> score_1;

	while (y < student_number)
	{
		y++;
		
		cout << "Enter student" << y << "'s name and score\n";
		int score_2;
		string name_2;
		cin >> name_2 >> score_2;

		if (score_1 < score_2)
		{
			int temp_score = score_2;
			score_1 = score_2;
			score_2 = temp_score;

			string temp_name = name_2;
			name_1 = name_2;
			name_2 = temp_name;
		}
	}
	cout << "A student with the highest score is " << name_1 << " and this student scored " << score_1;

	return 0;
}