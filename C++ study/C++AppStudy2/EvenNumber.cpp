#include "EvenNumber.h"

EvenNumber::EvenNumber()
{
	value = 0;
}

EvenNumber::EvenNumber(int nNum)
{
	value = nNum;
}

int EvenNumber::getValue()
{
	return value;
}

int EvenNumber::getNext()
{
	return value + 2;
}

int EvenNumber::getPrevious()
{
	return value - 2;
}
