#include <stdio.h>
#include "C:\Projetos\MyClassTeste\MyClassTeste\stdafx.h"
#include "C:\Projetos\MyClassTeste\MyClassTeste\header.h"
#include "C:\Projetos\MyClassTeste\MyClassTeste\body.cpp"
#include "dll_function.h"


extern "C"
{
	_declspec(dllexport) void DisplayHelloFromDLL() {
		printf("Hello from DLL !\n");
		int result, num =4, num2 =4;
		result = num * num2;
		printf("Resultado do Calculo %d ", result);
		myClass MC(20, 30);
		printf("Resultado da soma externa %lf ", MC.sumX_Y());
	}

	_declspec(dllexport) void showMessageFromOut() {
		double resu, num01 = 3, num02 = 4;

		resu = num01 * num02;
		printf("Esse e mais um teste de impressão de dll!\n");
		printf("Resultado da conta: %lf ", resu);
		printf("Encerrando a conta na DLL! \n");
	}

	_declspec(dllexport) void ChamaFuncStringDesc(int(__stdcall *funcDesconhecida)()) {
		printf("\nEntrou na DLL para func Desconhecida\n");
		funcDesconhecida();
		printf("\nDepois da chamada func Desconhecida dentro da DLL\n");
	}

	_declspec(dllexport) void ChamaFuncIntDesc(int x, int(__stdcall *funcDesconhecida)(int valor)) {
		printf("\n Dentro da DLL fazendo o Calculo Complexo para mostrar o resultado\n");
		int numero = x, num = 0;
		
		//for (num = 0; num <= numero; num++) {
		//	numero = (numero + num + ((num + numero) / 3))  * 3;
		//}
		numero++;
		printf("\n fim do Calculo Complexo dentro da DLL\n");
		funcDesconhecida(numero);

		
	}

}