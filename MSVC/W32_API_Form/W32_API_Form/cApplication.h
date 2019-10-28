#pragma once
#include <windows.h>
#include <string>

using namespace std;


class cApplication
{
public:
	//cApplication();
	cApplication(HINSTANCE hInstance);

	~cApplication();

	bool Init();
	
	LRESULT		MsgProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam);

private:

	bool		InitWindow();


	

	HWND		m_hAppWnd;
	HINSTANCE	m_hAppInstance;
	UINT		m_ClientWidth;
	UINT		m_ClientHeight;
	string		m_AppTitle;
	DWORD		m_WndStyle;


};

