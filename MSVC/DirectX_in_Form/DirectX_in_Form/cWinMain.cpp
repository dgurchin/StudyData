#include <windows.h>
#include "cApplication.h"


int WINAPI WinMain(__in HINSTANCE hInstance, __in_opt HINSTANCE hPrevInstance, __in LPSTR lpCmdLine, __in int nShowCMD)
{
	cApplication o_Application(hInstance);

	if (!o_Application.Init())
	{
		return 1;
	}

	return o_Application.Run();

	
}