#include "cDirectX.h"
#include <windows.h>
#include <minwinbase.h>
#include <d3d11.h>
#include <minwinbase.h>
using namespace Memory;


namespace
{
	cDirectX *g_pApp = nullptr;

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

cDirectX::cDirectX(HINSTANCE hInstance)
{
	m_hAppInstance = hInstance;

	m_hAppWnd = NULL;

	m_ClientWidth = 800;

	m_ClientHeight = 600;

	m_WndStyle = WS_OVERLAPPEDWINDOW;

	m_AppTitle = "+++++++";

	g_pApp = this;


	m_pDevice = nullptr;

	m_pImmediateContext = nullptr;

	m_pRenderTargetView = nullptr;

	m_pSwapChain = nullptr;

}


cDirectX::~cDirectX()
{
	if (m_pImmediateContext) m_pImmediateContext->ClearState();

	SafeRealeas(m_pRenderTargetView);

	SafeRealeas(m_pSwapChain);

	SafeRealeas(m_pImmediateContext);

	SafeRealeas(m_pDevice);
}

int cDirectX::Run()
{
	MSG msg = { 0 };

	while (WM_QUIT != msg.message)
	{
		if (PeekMessageA(&msg, NULL, NULL, NULL, PM_REMOVE))
		{
			TranslateMessage(&msg);

			DispatchMessageA(&msg);
		}
		else
		{
			Update(0.0f);

			Render(0.0f);
		}


	}

	return static_cast<int>(msg.wParam);
}

bool cDirectX::Init()
{
	if (!InitWindow())
		return false;


	if (!InitDirect3D())
		return false;

	return true;
}

LRESULT cDirectX::MsgProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam)
{
	switch (msg)
	{


	case WM_PAINT:
		
		Render(0.0f);
		break;


	case WM_DESTROY:
		PostQuitMessage(0);


		break;
	default:
		return DefWindowProcA(hwnd, msg, wParam, lParam);



	}
}

bool cDirectX::InitDirect3D()
{
	UINT createDeviceFlags = 0;

#ifdef DEBUG

	createDeviceFlags |= D3D11_CREATE_DEVICE_DEBUG;

#endif

	D3D_DRIVER_TYPE driverTypes[] =
	{
		D3D_DRIVER_TYPE_HARDWARE,

		D3D_DRIVER_TYPE_WARP,

		D3D_DRIVER_TYPE_REFERENCE
	};

	UINT numDriverTypes = ARRAYSIZE(driverTypes);


	D3D_FEATURE_LEVEL featureLevels[] =
	{
		D3D_FEATURE_LEVEL_11_0,

		D3D_FEATURE_LEVEL_10_1,

		D3D_FEATURE_LEVEL_10_0,

		D3D_FEATURE_LEVEL_9_3
	};

	UINT numFeatureLevels = ARRAYSIZE(featureLevels);

	DXGI_SWAP_CHAIN_DESC swapDesc;

	ZeroMemory(&swapDesc, sizeof(DXGI_SWAP_CHAIN_DESC));

	swapDesc.BufferCount = 1;

	swapDesc.BufferDesc.Width = m_ClientHeight;

	swapDesc.BufferDesc.Height = m_ClientHeight;

	swapDesc.BufferDesc.Format = DXGI_FORMAT_R8G8B8A8_UNORM;

	swapDesc.BufferDesc.RefreshRate.Numerator = 60;

	swapDesc.BufferDesc.RefreshRate.Denominator = 1;

	swapDesc.BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT;

	swapDesc.OutputWindow = m_hAppWnd;

	swapDesc.SwapEffect = DXGI_SWAP_EFFECT_DISCARD;

	swapDesc.Windowed = true;

	swapDesc.SampleDesc.Count = 1;

	swapDesc.SampleDesc.Quality = 0;

	swapDesc.Flags = DXGI_SWAP_CHAIN_FLAG_ALLOW_MODE_SWITCH;


	HRESULT result;


	for (int i = 0; i < numDriverTypes; i++)
	{
		result = D3D11CreateDeviceAndSwapChain(NULL, driverTypes[i], NULL, createDeviceFlags, featureLevels,
			numFeatureLevels, D3D11_SDK_VERSION, &swapDesc, &m_pSwapChain, &m_pDevice, &m_FeatureLevel, &m_pImmediateContext);


		if (SUCCEEDED(result))
		{
			m_DriverType = driverTypes[i];

			break;
		}
	}


	if (FAILED(result))
	{
		OutputDebugString("Failed to Create Device And SWAP Chain");

		return false;
	}


	ID3D11Texture2D* m_pBackBufferText = 0;

	m_pSwapChain->GetBuffer(NULL, __uuidof(ID3D11Texture2D), reinterpret_cast<void**>(&m_pBackBufferText));

	m_pDevice->CreateRenderTargetView(m_pBackBufferText, nullptr, &m_pRenderTargetView);



	m_pImmediateContext->OMSetRenderTargets(1, &m_pRenderTargetView, nullptr);


	m_Viewport.Width = static_cast<float>(m_ClientWidth);

	m_Viewport.Height = static_cast<float>(m_ClientHeight);

	m_Viewport.TopLeftX = 0;

	m_Viewport.TopLeftY = 0;

	m_Viewport.MinDepth = 0;

	m_Viewport.MaxDepth = 1;



	m_pImmediateContext->RSSetViewports(1, &m_Viewport);


	return true;

	
}

bool cDirectX::InitWindow()
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



	wcex.hbrBackground = (HBRUSH)GetStockObject(NULL_BRUSH);

	//wcex.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);

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

	return  true;
}
