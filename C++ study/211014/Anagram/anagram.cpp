#include<iostream>
#include<string>
using namespace std;

void stringSort(string& list)
{
	for (unsigned int i = 0; i < list.length() - 1; i++)
	{
		char currentMin = list[i];
		int currentMinIndex = i;

		for (unsigned int j = i + 1; j < list.length(); j++)
		{
			if (currentMin > list[j])
			{
				currentMin = list[j];
				currentMinIndex = j;
			}
		}

		if (currentMinIndex != i)
		{
			list[currentMinIndex] = list[i];
			list[i] = currentMin;
		}
	}
}

bool isAnagram(const string& s1, const string& s2)
{
	if (s1.length() != s2.length())
	{
		cout << " are not anagrams" << endl;

		return false;
	}

	if (s1 == s2)
	{
		cout << " are anagrams" << endl;

		return true;
	}
	else
	{
		cout << " are not anagrams" << endl;

		return false;
	}
}

int main()
{
	cout << "<Exercise 10-1>" << endl;

	string s1, s2;

	s1 = "silent";
	s2 = "listen";

	cout << s1 << " and " << s2;

	stringSort(s1);
	stringSort(s2);

	isAnagram(s1, s2);

	s1 = "split";
	s2 = "lisp";

	cout << s1 << " and " << s2;

	stringSort(s1);
	stringSort(s2);

	isAnagram(s1, s2);

	cout << "Enter a string s1 : ";
	cin >> s1;
	cout << "Enter a string s2 : ";
	cin >> s2;

	cout << s1 << " and " << s2;

	stringSort(s1);
	stringSort(s2);

	isAnagram(s1, s2);

	return 0;
}