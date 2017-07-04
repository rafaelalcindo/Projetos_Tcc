#include <stdio.h>
#include <conio.h>
#include <Windows.h>

int main(int argc, char * args[]){
	HMODULE libHandle;
	
	if((libHandle = LoadLibrary(TEXT("LibraryCsharp.dll"))) == NULL){
		printf("Load failed\n");
		return 1;
	}
	
	
	if(GetProcAddress(libHandle,"addUp") == NULL){
		printf("GetProcAddress failed\n");
		printf("%d\n", GetLastError());
		return 1;
	}else{
		
	}
	
	
	return 0;
}

