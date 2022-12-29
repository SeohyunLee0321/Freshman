#include <iostream>
#include "CourseWithCustomCopyConstructor.h"
using namespace std;

int main()
{
	Course course1("C++ Programming", 10);
	
	course1.addStudent("Peter");
	course1.addStudent("Adam");

	Course course2(course1);
	course2.addStudent("Lisa");
	course1.addStudent("Joseph");

	string* students = course2.getStudents();
	int size = course2.getNumberOfStudents();
	for (int i = 0; i < size; i++)
	{
		cout << students[i] << (i < size - 1 ? ", " : "");
	}

	return 0;
}