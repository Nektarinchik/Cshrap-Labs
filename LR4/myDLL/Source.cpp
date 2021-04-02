#include "pch.h"
#include "Source.h"
#include <math.h>

int _stdcall Sum(int firstValue, int secondValue)
{
	return firstValue + secondValue;
}

int _stdcall Subtract(int firstValue, int secondValue)
{
	return firstValue - secondValue;
}

int _stdcall Multiply(int firstValue, int secondValue)
{
	return firstValue * secondValue;
}

int _stdcall Divide(int firstValue, int secondValue)
{
	if (secondValue)
		return firstValue / secondValue;
	return 0;
}

int _stdcall Mod(int firstValue, int secondValue)
{
	if (secondValue)
		return firstValue % secondValue;
	return 0;
}

int _stdcall Abs(int value)
{
	int sign = value > 0 ? 1 : -1;
	return sign * value;
}

int __cdecl Pow(int firstValue, int secondValue)
{
	int resValue = 1;
	for (int i = 0; i < secondValue; ++i) {
		resValue *= firstValue;
	}
	return resValue;
}

int __cdecl Min(int firstValue, int secondValue)
{
	return firstValue < secondValue ? firstValue : secondValue;
}

int __cdecl Max(int firstValue, int secondValue)
{
	return firstValue > secondValue ? firstValue : secondValue;
}


