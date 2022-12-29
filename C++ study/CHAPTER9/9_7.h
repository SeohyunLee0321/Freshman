#ifndef STOPWATCH_H
#define STOPWATCH_H

class StopWatch
{
public:
	int startTime, endTime;

	StopWatch();

	int start();
	int stop();
	int getElapsedTime();
};

#endif