#include "cApplication.h"

namespace
{
	cApplication *g_pApp = nullptr;

}

LRESULT CALLBACK MainWndProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam)
{
	if (g_pApp)
	{
		return g_pApp->MsgProc(hwnd, msg, wParam, lParam);
	}
	else
	{
		return DefWindowProc(hwnd, msg, wParam, lParam);
	}
}

//cApplication::cApplication()
//{
//
//}

cApplication::cApplication(HINSTANCE hInstance)
{
	m_hAppInstance = hInstance;

	m_hAppWnd = NULL;

	m_ClientWidth = 800;

	m_ClientHeight = 600;

	m_WndStyle = WS_OVERLAPPEDWINDOW;

	m_AppTitle = "+++++++";

	g_pApp = this;
}


cApplication::~cApplication()
{

}




bool cApplication::Init()
{
	return InitWindow();
}


bool cApplication::InitWindow()
{

	WNDCLASSEX wcex;

	ZeroMemory(&wcex, sizeof(WNDCLASSEX));

	wcex.cbClsExtra = 0;

	wcex.cbWndExtra = 0;

	wcex.cbSize = sizeof(WNDCLASSEX);

	wcex.style = CS_HREDRAW | CS_VREDRAW;

	wcex.hInstance = m_hAppInstance;

	wcex.lpfnWndProc = MainWndProc;

	wcex.hIcon = LoadIconA(NULL, IDI_APPLICATION);

	wcex.hCursor = LoadCursorA(NULL, IDC_ARROW);



	//wcex.hbrBackground = (HBRUSH)GetStockObject(NULL_BRUSH);

	wcex.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);

	wcex.lpszMenuName = NULL;

	wcex.lpszClassName = "DXAPPWNDCLASS";

	wcex.hIconSm = LoadIconA(NULL, IDI_APPLICATION);

	if (!RegisterClassEx(&wcex))
	{
		OutputDebugStringA("\n FAILED Create WINDOWS CLASS\n");

		return false;
	}

	RECT r = { 0,0,m_ClientWidth, m_ClientHeight };

	AdjustWindowRect(&r, m_WndStyle, FALSE);

	UINT width = r.right - r.left;

	UINT height = r.bottom - r.top;


	UINT x = GetSystemMetrics(SM_CXSCREEN) / 2 - width / 2;

	UINT y = GetSystemMetrics(SM_CXSCREEN) / 2 - height / 2;

	//m_hAppWnd = CreateWindowExA(0L,"DXAPPWNDCLASS", m_AppTitle.c_str(), m_WndStyle, x, y, width,height, NULL, NULL, m_hAppInstance, NULL);

	m_hAppWnd = CreateWindow("DXAPPWNDCLASS", m_AppTitle.c_str(), m_WndStyle, x, y, width, height, NULL, NULL, m_hAppInstance, NULL);

	if (!m_hAppWnd)
	{
		OutputDebugString("\nFAILED Create WINDOW\n");

		return false;
	}

	ShowWindow(m_hAppWnd, SW_SHOW);


	MSG msg;

	while (GetMessage(&msg, NULL, 0, 0))
	{
		TranslateMessage(&msg);

		DispatchMessageA(&msg);

	}


	return  true;

}

LRESULT cApplication::MsgProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam)
{

	switch (msg)
	{

	case WM_DESTROY:
		PostQuitMessage(0);
		break;


	default:
		return DefWindowProcA(hwnd, msg, wParam, lParam);



	}

	return LRESULT();
}
