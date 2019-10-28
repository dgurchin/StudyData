// Win32Project1.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "Win32Project1.h"

#include <comutil.h>
#include <string>

WIN32PROJECT1_API BSTR GetSomeText()
{
    return ::SysAllocString(L"Greetings from the native world!");
}



// This is an example of an exported function.
WIN32PROJECT1_API BSTR m()
{
	std::string mystring("Some characters");

std::string::const_reference(__thiscall std::string::*atFunc)(std::string::size_type) const = &std::string::at;
unsigned int atAddress = PtrToUlong((void*&)atFunc); 
char output = 0;

__asm
{
    mov eax, atAddress

    push 5
    lea ecx, [mystring]
    call eax

    mov al, [eax]
    mov [output], al
}

    BSTR result = NULL;
    int lenA = lstrlenA(&output);
    int lenW = ::MultiByteToWideChar(CP_ACP, 0, &output, lenA, NULL, 0);
    
	if (lenW > 0)
    {
        result = ::SysAllocStringLen(0, lenW);
        ::MultiByteToWideChar(CP_ACP, 0, &output, lenA, result, lenW);
	}

    return result;
}


	


