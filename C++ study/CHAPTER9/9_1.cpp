#include<iostream>
#include "9_1.h"
using namespace std;

Rectangle::Rectangle()
{
	width = 1;
	height = 1;
}

Rectangle::Rectangle(double newWidth, double newHeight)
{
	width = newWidth;
	height = newHeight;
}

void Rectangle::setWidth(double newWidth)
{
	width = newWidth;
}

double Rectangle::getWidth()
{
	return width;
}

void Rectangle::setHeight(double newHeight)
{
	height = newHeight;
}

double Rectangle::getHeight()
{
	return height;
}

double Rectangle::getArea()
{
	return width * height;
}

double Rectangle::getPerimeter()
{
	return (width + height) * 2;
}

int main()
{
	Rectangle rectangle1(4, 40);
	Rectangle rectangle2(3.5, 35.9);

	cout << "The area and perimeter of the rectangle of width " << rectangle1.getWidth() << " and height " << rectangle1.getHeight()
		<< " is " << rectangle1.getArea() << " and " << rectangle1.getPerimeter() << endl;
	cout << "The area and perimeter of the rectangle of width " << rectangle2.getWidth() << " and height " << rectangle2.getHeight()
		<< " is " << rectangle2.getArea() << " and " << rectangle2.getPerimeter() << endl;

	return 0;
}