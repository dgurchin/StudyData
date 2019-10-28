#pragma once


#include <windows.h>
#include <minwinbase.h>
#include <DirectXColors.h>
#include <d3d11.h>
#include <string>



#pragma comment (lib, "d3d11.lib")


using namespace std;

namespace Memory
{
	template <class T> void SafeDelete(T &t)
	{
		if (t)
		{
			delete t;

			t = nullptr;
		}
	}

	template <class T> void SafeDeleteArr(T &t)
	{
		if (t)
		{
			delete[]  t;

			t = nullptr;
		}
	}


	template <class T> void SafeRealeas(T &t)
	{
		if (t)
		{
			t->Release();

			t = nullptr;
		}
	}
}




class cDirectX
{
public:
	cDirectX(HINSTANCE hInstance);
	
	virtual ~cDirectX();

	int Run();

	virtual bool Init();

	virtual void Update(float dt) = 0;

	virtual void Render(float dt) = 0;

	virtual LRESULT MsgProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam);

protected:

	HWND		m_hAppWnd;
	HINSTANCE	m_hAppInstance;
	UINT		m_ClientWidth;
	UINT		m_ClientHeight;
	string		m_AppTitle;
	DWORD		m_WndStyle;




	ID3D11Device*				m_pDevice;
	ID3D11DeviceContext*		m_pImmediateContext;
	IDXGISwapChain*				m_pSwapChain;
	ID3D11RenderTargetView*		m_pRenderTargetView;
	D3D_DRIVER_TYPE				m_DriverType;
	D3D_FEATURE_LEVEL			m_FeatureLevel;
	D3D11_VIEWPORT				m_Viewport;


	bool InitDirect3D();

private:
	bool		InitWindow();



};

