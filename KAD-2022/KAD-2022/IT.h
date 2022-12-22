#pragma once
#include <string>
#include <stack>
#include <vector>

using namespace std;

#define ID_MAXSIZE			21				// максимальное количество символов в идентификаторе + '\0'
#define TI_MAXSIZE			4096			// максимальное количество эл-ов в таблице идентификаторов 
#define TI_INT_DEFAULT		0x00000000		// значение по умолчанию для типа integer 
#define TI_STR_DEFAULT		0x00			// значение по умолчанию для типа string 
#define TI_NULLIDX			0xffffffff		// нет элемента таблицы идентификаторов
#define GLOBAL				"global"		// именование глобальной области видимости
#define TI_STR_MAXSIZE		256				// максимальный размер строки + '\0'
#define FUNC_COPY			"copy"		// идентификатор стандартоной функции
#define FUNC_LEN			"lenght"	// идентификатор стандартоной функции
#define FUNC_TIME			"getLocalTimeAndDate"	// идентификатор стандартоной функции
#define FUNC_POW			"powNumber"				// идентификатор стандартоной функции
#define FUNC_RANDOM			"random"				// идентификатор стандартоной функции
#define FUNC_FACTORIAL		"factorialOfNumber"				// идентификатор стандартоной функции
#define FUNC_SQUARE			"squareOfNumber"				// идентификатор стандартоной функции


#define PARM_ID_DEFAULT_LOCATION		L"C:\\CourseProject\\KAD-2022\\Debug\\Files\\"
#define PARM_ID_DEFAULT_EXT				L".id.txt" //для файла с итогом лексического анализa(таблица идентификаторов и литералов)

namespace IT	// таблица идентификатов
{
	enum class IDDATATYPE { DEF, INT, STR };						// типы данных идентификаторов: не определен, integer, string
	enum class IDTYPE { D, V, F, P, L, C };							// типы идентификаторов: не определен, переменная, функция, параметр, литерал

	struct Entry	// строка таблицы идентификаторов
	{
		int idxfirstLE;							// индекс первой строки в таблице лексем
		char areaOfVisibility[ID_MAXSIZE]{};	// область видимости
		char id[ID_MAXSIZE]{};					// идентификатор (автоматически усекается до ID_MAXSIZE)
		IDDATATYPE	iddatatype;					// тип данных
		IDTYPE	idtype;							// тип идентикатора
		union
		{
			int vint;							// значение integer
			struct
			{
				unsigned char len;				// количесво символов в string
				char str[TI_STR_MAXSIZE];		// символы string
			} vstr;								// значение string
		}value;									// значение идентификатора
		struct Param
		{
			int count;							// количество параметров функции
			vector<IDDATATYPE> types;			// типы параметров функции
		} params;
		string FullName;
		Entry(int idxfirstLE, string areaOfVisibility, const char* id, IDDATATYPE iddatatype, IDTYPE idtype);
		Entry(int idxfirstLE, IDDATATYPE iddatatype, IDTYPE idtype, char* value);
	};
	struct IdTable // экземпляр таблицы идентификаторов
	{
		int maxsize;				// емкость таблицы идентификаторов < TI_MAXSIZE
		int current_size;			// текущий размер таблицы идентификаторов < maxsize
		Entry** table;				// массив указателей на строки таблицы идентификаторов

		IdTable(int size);
	};

	//статические функции
	static Entry len(0, string(GLOBAL), FUNC_LEN, IDDATATYPE::INT, IDTYPE::F);
	static Entry copy(0, string(GLOBAL), FUNC_COPY, IDDATATYPE::STR, IDTYPE::F);
	static Entry time(0, string(GLOBAL), FUNC_TIME, IDDATATYPE::STR, IDTYPE::F);
	static Entry pow(0, string(GLOBAL), FUNC_POW, IDDATATYPE::INT, IDTYPE::F);
	static Entry random(0, string(GLOBAL), FUNC_RANDOM, IDDATATYPE::INT, IDTYPE::F);
	static Entry factorial(0, string(GLOBAL), FUNC_FACTORIAL, IDDATATYPE::INT, IDTYPE::F);
	static Entry square(0, string(GLOBAL), FUNC_SQUARE, IDDATATYPE::INT, IDTYPE::F);

	void Add(IdTable& idtable, Entry* entry);
	Entry GetEntry(IdTable& idtable, int n);
	int IsId(IdTable& idtable, char id[ID_MAXSIZE], stack<string> areaOfVisibility);
	int IsLiteralInt(IdTable& idtable, char* lexema);
	int IsLiteralString(IdTable& idtable, char* lexema);
	void PrintIdTable(IdTable& idtable, const wchar_t* in);
	void Delete(IdTable& idtable);
}