#include<iostream>
#include<string>
#include "9_1.h"
#include "9_2.h"
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

Fan::Fan()
{
	speed = 1;
	on = false;
	radius = 5;
	color = "white";
}

int Fan::getSpeed()
{
	return speed;
}

void Fan::setSpeed(int newSpeed)
{
	speed = newSpeed;
}

bool Fan::getOn()
{
	return on;
}

void Fan::setOn(bool newOn)
{
	on = newOn;
}

double Fan::getRadius()
{
	return radius;
}

void Fan::setRadius(double newRadius)
{
	radius = newRadius;
}

string Fan::getColor()
{
	return color;
}

void Fan::setColor(string newColor)
{
	color = newColor;
}

int main()
{
	Rectangle rectangle1(4, 40);
	Rectangle rectangle2(3.5, 35.9);

	cout << "<Exercise 09-01>" << endl;
	cout << "The first rectangle : width = " << rectangle1.getWidth() << ", height = " << rectangle1.getHeight() << endl
		 << "Area = " << rectangle1.getArea() << endl
		 << "Perimeter = " << rectangle1.getPerimeter() << endl << endl;
	cout << "The second rectangle : width = " << rectangle2.getWidth() << ", height = " << rectangle2.getHeight() << endl
		 << "Area = " << rectangle2.getArea() << endl
		 << "Perimeter = " << rectangle2.getPerimeter() << endl << endl;

	cout << "-----------------------------------------------------------------------------------------------------" << endl;

	cout << "<Exercise 09-02>" << endl;

	Fan fan1, fan2;

	fan1.setSpeed(3);
	fan1.setRadius(10);
	fan1.setOn(true);
	fan1.setColor("yellow");

	fan2.setSpeed(2);
	fan2.setRadius(5);
	fan2.setOn(false);
	fan2.setColor("white");

	string fan1_state = (fan1.getOn()) ? "on" : "off";
	string fan2_state = (fan2.getOn()) ? "on" : "off";

	cout << "First fan properties\n"
		 << "Fan speed : " << fan1.getSpeed() << endl
		 << "Fan radius : " << fan1.getRadius() << endl
		 << "Fan on/off : " << fan1_state << endl
		 << "Fan color : " << fan1.getColor() << endl << endl;

	cout << "Second fan properties\n"
		<< "Fan speed : " << fan2.getSpeed() << endl
		<< "Fan radius : " << fan2.getRadius() << endl
		<< "Fan on/off : " << fan2_state << endl
		<< "Fan color : " << fan2.getColor() << endl << endl;

	return 0;
}