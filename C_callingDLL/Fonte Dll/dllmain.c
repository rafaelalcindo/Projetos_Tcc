/* Replace "dll.h" with the name of your header */
#include "dll.h"
#include <windows.h>

//Funcao exportada para o C#
DLLIMPORT void ChamaFunc(int (__stdcall *funcDesconhecida)()){	
	funcDesconhecida();
}


