#define DLLIMPORT __declspec(dllexport)

DLLIMPORT void ChamaFunc(int (__stdcall *funcDesconhecida)(const char** str, int len));


