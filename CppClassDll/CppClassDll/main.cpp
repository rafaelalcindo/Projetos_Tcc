#include "C:\Projetos\MyClassTeste\MyClassTeste\header.h"
#include "C:\Projetos\MyClassTeste\MyClassTeste\body.cpp"

extern "C" __declspec(dllexport) double sumTwo(double var_x,double var_y)
{
	myClass MC(var_x, var_y);
	return MC.sumX_Y();
}