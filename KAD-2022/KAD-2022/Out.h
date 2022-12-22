#pragma once
#include "Parm.h"
#include <fstream>

namespace Out
{
	struct OUT
	{
		wchar_t outfile[PARM_MAX_SIZE];
		std::ofstream* stream;

		OUT();
	};

	OUT getout(wchar_t outfile[]);							// Создание и открытие потокового вывода

	void Close(OUT out);									// Закрытие потока вывода
}