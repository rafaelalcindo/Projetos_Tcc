#pragma once
#include "stdafx.h"
#include "header.h"

/*myClass::myClass(double var_x, double var_y)
{
	x = var_x;
	y = var_y;
}*/

myClass::myClass(int var_fat) {
	fat = var_fat;
}

int myClass::Fatorial() {
	int valor01 = 0, valor02 = 0, valor03 = 0, fatorial = 0;
	valor01 = fat;
	valor03 = fat;
		
	for (int i = 0; i <= fat; i++) {
		valor01--;
		if (valor01 > 0) {
			valor02 = valor03 * valor01;
			fatorial = valor02;
			valor03 = valor02;
		}
	}

	return fatorial;
}

/*double myClass::sumX_Y()
{
	return x + y;
}*/

