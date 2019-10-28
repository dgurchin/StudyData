#pragma once

#include <windows.h>
#include "cDirectX.h"

class cApplication : public cDirectX
{
public:
	cApplication(HINSTANCE hInstance);

	~cApplication();

	void Render(float dt) override;

	void Update(float dt) override;
};

