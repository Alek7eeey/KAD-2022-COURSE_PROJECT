#include "stdafx.h"
#include "Parm.h"
#include "Error.h"

namespace Parm
{
	// ------- Обработка входных параметров --------
	PARM getparm(int argc, wchar_t* argv[])
	{
		if (argc == 1)
			throw ERROR_THROW(100);

		wchar_t* ptrIN = NULL,
			* ptrOUT = NULL,
			* ptrLOG = NULL;

		for (int i = 1; i < argc; i++)
		{
			if (wcslen(argv[i]) > PARM_MAX_SIZE)
				throw ERROR_THROW(104);

			if (!ptrIN && wcsstr(argv[i], PARM_IN))
			{
				ptrIN = wcsstr(argv[i], PARM_IN) + wcslen(PARM_IN);
				continue;
			}

			if (!ptrOUT && wcsstr(argv[i], PARM_OUT))
			{
				ptrOUT = wcsstr(argv[i], PARM_OUT) + wcslen(PARM_OUT);
				continue;
			}

			if (!ptrLOG && wcsstr(argv[i], PARM_LOG))
				ptrLOG = wcsstr(argv[i], PARM_LOG) + wcslen(PARM_LOG);
		}

		PARM parm;

		//------------- параметр IN -------------
		if (ptrIN)
			wcscpy(parm.in, ptrIN);
		else
			throw ERROR_THROW(100);

		//------------- параметр OUT -------------
		if (ptrOUT)
			wcscpy(parm.out, ptrOUT);
		else
		{
			wcscpy(parm.out, ptrIN);
			wcscat(parm.out, PARM_OUT_DEFAULT_EXT);
		}
		//------------- параметр LOG -------------
		if (ptrLOG)
			wcscpy(parm.log, ptrLOG);
		else
		{
			wcscpy(parm.log, ptrIN);
			wcscat(parm.log, PARM_LOG_DEFAULT_EXT);
		}
		return parm;
	}
}

