#pragma once

#define DLLIMPORT __declspec(dllexport)

DLLIMPORT void ChamaFunc(int(__stdcall *funcDesconhecida)(int valor));

DLLIMPORT void ChamaFuncString(int(__stdcall *funcDesconhecida)(const char** str, int len));

DLLIMPORT void CalcularResisEletrica(int(__stdcall *funcDesconhecida)(double valor1, double valor2));

DLLIMPORT void HelloWorld();

DLLIMPORT void showMessageFromDll();
