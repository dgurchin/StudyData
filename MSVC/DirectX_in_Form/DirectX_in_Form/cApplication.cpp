#include "cApplication.h"



cApplication::cApplication(HINSTANCE hInstance) : cDirectX(hInstance)
{

}


cApplication::~cApplication()
{

}

void cApplication::Render(float dt)
{
	m_pImmediateContext->ClearRenderTargetView(m_pRenderTargetView, DirectX::Colors::CornflowerBlue);

	m_pSwapChain->Present(0, 0);
}

void cApplication::Update(float dt)
{

}

