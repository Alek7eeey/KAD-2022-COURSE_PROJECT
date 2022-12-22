#include "stdafx.h"
#include "Log.h"
#include "Error.h"

using namespace std;

namespace Log
{
	LOG::LOG()
	{
		memset(logfile, NULL, sizeof(wchar_t) * MAX_LEN_MESSAGE);
		stream = NULL;
	}
	// ------- Создание и открытие потокового вывода протокола -------
	LOG getlog(wchar_t logfile[])
	{
		LOG log;
		log.stream = new std::ofstream;
		log.stream->open(logfile);

		if (!log.stream->is_open())
			throw ERROR_THROW(106);

		wcscpy(log.logfile, logfile);

		return log;
	}

	// ------- Вывода одной строки в протокол char -------
	void WriteLine(std::ostream* stream, const char* c, ...)
	{
		const char** ptrC = &c;
		while (*ptrC != "")
		{
			*stream << *ptrC;
			ptrC++;
		}
		*stream << endl;
	}

	// ------- Вывода одной строки в протокол wchar_t -------
	void WriteLine(std::ostream* stream, const wchar_t* c, ...)
	{
		const wchar_t** ptrC = &c;
		char tempC[MAX_LEN_MESSAGE];

		while (*ptrC != L"")
		{
			wcstombs(tempC, *ptrC, MAX_LEN_MESSAGE);
			*stream << tempC;
			ptrC++;
		}

		*stream << endl;
	}

	// ------- Вывод заголовка протокола -------
	void WriteLog(std::ostream* stream)
	{
		char buffer[48];
		time_t rawtime;
		time(&rawtime);							// получить текущую дату, выраженную в секундах
		tm* timeinfo = localtime(&rawtime);		// текущая дата, представленная в нормальной форме

		strftime(buffer, 48, "Дата: %d.%m.%Y %A %H:%M:%S ", timeinfo);

		*stream << "----- Протокол ----- " << buffer << endl << endl;
	}

	// ------- Вывод в протокол информации о входных параметрах -------
	void WriteParm(std::ostream* stream, Parm::PARM parm)
	{
		char* ptrIn = new char[PARM_MAX_SIZE],
			* ptrOut = new char[PARM_MAX_SIZE],
			* ptrLog = new char[PARM_MAX_SIZE];

		wcstombs(ptrIn, parm.in, PARM_MAX_SIZE);
		wcstombs(ptrOut, parm.out, PARM_MAX_SIZE);
		wcstombs(ptrLog, parm.log, PARM_MAX_SIZE);

		*stream << "----- Параметры -----" << endl <<
			"-log: " << ptrLog << endl <<
			"-out: " << ptrOut << endl <<
			"-in: " << ptrIn << endl << endl;

		delete[] ptrIn, ptrOut, ptrLog;
	}

	// ------- Вывод в протокол информации о файле -------
	void WriteIn(std::ostream* stream, In::IN in)
	{
		*stream << "----- Исходные данные -----" << endl <<
			"Количество символов\t: " << in.size << endl <<
			"Проигнорировано\t\t: " << in.ignor << endl <<
			"Количество строк\t: " << in.lines << endl << endl;

		//delete[] in.text;			//Нужно разобраться когда чистить память
	}

	// ------- Вывод в протокол информации об ошибке -------
	void WriteError(std::ostream* stream, Error::ERROR error)
	{
		if (error.inext.line == -1)
			*stream << "Ошибка " << error.id << ": " << error.message << endl;
		else if (error.id >= 110 && error.id <= 119)
		{
			*stream << "Ошибка при чтении из входного файла" << endl;
			*stream << "Ошибка " << error.id << ": " << error.message << ", строка " << error.inext.line << ", столбец " << error.inext.col << endl;
		}
		else if (error.id >= 120 && error.id <= 140)
		{
			*stream << "Ошибка на этапе лексического анализатора" << endl;
			*stream << "Ошибка " << error.id << ": " << error.message << ", строка " << error.inext.line << ", лексема " << error.inext.col << endl;
		}
		else if (error.id >= 700 && error.id <= 720)
		{
			*stream << "Ошибка на этапе Семантического анализатора" << endl;
			if (error.inext.col == -1)
				*stream << "Ошибка " << error.id << ": " << error.message << ", строка " << error.inext.line << endl;
			else
				*stream << "Ошибка " << error.id << ": " << error.message << ", строка " << error.inext.line << ", лексема " << error.inext.col << endl;
		}
	}

	// ------- Закрытие потока вывода протокола -------
	void Close(LOG log)
	{
		log.stream->close();
		delete log.stream;
	}
}
