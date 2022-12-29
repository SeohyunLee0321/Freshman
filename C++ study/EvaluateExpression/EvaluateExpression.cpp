#include <iostream>
#include <vector>
#include <string>
#include <cctype>
#include "ImprovedStack.h"

using namespace std;

vector<string> split(const string& expression);

int evaluateExpression(const string& expression);

void processAnOperator(Stack<int>& operandStack, Stack<char>& operatorStack);

int main()
{
	string expression;
	cout << "Enter an expression : ";
	getline(cin, expression);

	cout << expression << " = "
		<< evaluateExpression(expression) << endl;

	return 0;
}

vector<string> split(const string& expression)
{
	vector<string> v;
	string numberString;

	for (unsigned i = 0; i < expression.length(); i++)
	{
		if (isdigit(expression[i]))
			numberString.append(1, expression[i]);
		else
		{
			if (numberString.size() > 0)
			{
				v.push_back(numberString);
				numberString.erase();
			}

			if (!isspace(expression[i]))
			{
				string s;
				s.append(1, expression[i]);
				v.push_back(s);
			}
		}
	}

	if (numberString.size() > 0)
		v.push_back(numberString);

	return v;
}

int evaluateExpression(const string& expression)
{
	Stack<int> operandStack;
	Stack<char> operatorStack;

	vector<string> tokens = split(expression);

	for (unsigned i = 0; i < tokens.size(); i++)
	{
		if (tokens[i][0] == '+' || tokens[i][0] == '-')
		{
			while (!operatorStack.empty() && (operatorStack.peek() == '+'
				|| operatorStack.peek() == '-' || operatorStack.peek() == '*'
				|| operatorStack.peek() == '/' || operatorStack.peek() == '%'
				|| operatorStack.peek() == '^'))
			{
				processAnOperator(operandStack, operatorStack);
			}

			operatorStack.push(tokens[i][0]);
		}
		else if (tokens[i][0] == '*' || tokens[i][0] == '/' || tokens[i][0] == '%')
		{
			while (!operatorStack.empty() && (operatorStack.peek() == '*'
				|| operatorStack.peek() == '/' || operatorStack.peek() == '%'
				|| operatorStack.peek() == '^'))
			{
				processAnOperator(operandStack, operatorStack);
			}

			operatorStack.push(tokens[i][0]);
		}
		else if (tokens[i][0] == '^')
		{
			while (!operatorStack.empty() && operatorStack.peek() == '^')
			{
				processAnOperator(operandStack, operatorStack);
			}

			operatorStack.push(tokens[i][0]);
		}
		else if (tokens[i][0] == '(')
		{
			operatorStack.push('(');
		}
		else if (tokens[i][0] == ')')
		{
			while (operatorStack.peek() != '(')
			{
				processAnOperator(operandStack, operatorStack);
			}

			operatorStack.pop();
		}
		else
		{
			operandStack.push(atoi(tokens[i].c_str()));
		}
	}

	while (!operatorStack.empty())
	{
		processAnOperator(operandStack, operatorStack);
	}

	return operandStack.pop();
}

void processAnOperator(Stack<int>& operandStack, Stack<char>& operatorStack)
{
	char op = operatorStack.pop();
	int op1 = operandStack.pop();
	int op2 = operandStack.pop();
	if (op == '+')
		operandStack.push(op2 + op1);
	else if (op == '-')
		operandStack.push(op2 - op1);
	else if (op == '*')
		operandStack.push(op2 * op1);
	else if (op == '/')
		operandStack.push(op2 / op1);
	else if (op == '%')
		operandStack.push(op2 % op1);
	else if (op == '^')
		operandStack.push((int)pow(op2, op1));
}