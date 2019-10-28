// CPP_Lib.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "CPP_Lib.h"
#include <ostream>
#include <iostream>

using namespace std;

// This is an example of an exported function.
CPP_LIB_API int funcCPP(int a, int b)
{
	return a+b;
}


CPP_LIB_API void f(const char *str)
{
	cout << str << endl;

	
	wstring stemp = s2ws(std::string(str));
	LPCWSTR result = stemp.c_str();

	MessageBox(0,  result, L"MessageBox caption", MB_CANCELTRYCONTINUE);
}


wstring s2ws(const string& s)
{
    int len;
    int slength = (int)s.length() + 1;
    len = MultiByteToWideChar(CP_ACP, 0, s.c_str(), slength, 0, 0); 
    wchar_t* buf = new wchar_t[len];
    MultiByteToWideChar(CP_ACP, 0, s.c_str(), slength, buf, len);
    wstring r(buf);
    delete[] buf;
    return r;
}

