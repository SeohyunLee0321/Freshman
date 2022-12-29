#include<iostream>
#include<ctime>
#include"9_7.h"
using namespace std;

#define MAX_SIZE 100000

int list[MAX_SIZE];

StopWatch::StopWatch()
{
	startTime = time(0);
}

int StopWatch::start()
{
	startTime = time(0);
	return startTime;
}

int StopWatch::stop()
{
	endTime = time(0);
	return endTime;
}

int StopWatch::getElapsedTime()
{
	return endTime - startTime;
}

void selectionSort(int list[])
{
	for (int i = 0; i < 100000 - 1; i++)
	{
		double currentMin = list[i];
		int currentMinIndex = i;

		for (int j = i + 1; j < 100000; j++)
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

int main()
{
	StopWatch stopwatch;
	stopwatch.start();
	selectionSort(list);
	stopwatch.stop();
	cout << stopwatch.getElapsedTime() << " seconds";
}