#include "stdafx.h"
#include "In.h"
#include "Error.h"

using namespace std;

namespace In
{
	// ------- Обработка информации из файла -------
	IN getin(wchar_t infile[])
	{
		IN in = { 0, 1, 0, new char[IN_MAX_LEN_TEXT] {}, IN_CODE_TABLE };

		ifstream fin(infile);
		if (!fin.is_open())
			throw ERROR_THROW(105);

		char ch;
		int currentCol = 0; // столбец в исходнике (-in)
		bool s_literal = false;

		while (fin.get(ch))
		{
			currentCol++;
			//	---------- Обработка символов -----------

			if (ch == IN_CODE_QUOTES)
				s_literal = !s_literal;

			if (s_literal)
			{
				if (ch == IN_CODE_ENDL)
					throw ERROR_THROW_IN(111, in.lines, currentCol);
				in.text[in.size] = ch;
				in.size++;
				continue;
			}

			switch (in.code[unsigned char(ch)])
			{
			case IN::F:
				throw ERROR_THROW_IN(110, in.lines, currentCol);
				break;

			case IN::T:
				in.text[in.size] = ch;
				in.size++;
				break;

			case IN::I:
				in.ignor++;
				break;

			case IN::S: // пробел и табуляция
				if (in.size)
					if (in.code[unsigned char(in.text[in.size - 1])] == IN::T || in.code[unsigned char(in.text[in.size - 1])] == IN::V)
					{
						in.text[in.size] = ch;
						in.size++;
					}
					else
						in.ignor++;
				break;

			case IN::V:
				if (in.size)
					if (in.code[unsigned char(in.text[in.size - 1])] != IN::S)
					{
						in.text[in.size] = IN_CODE_SPACE;
						in.size++;
					}
				in.text[in.size] = ch;
				in.size++;
				in.text[in.size] = IN_CODE_SPACE;
				in.size++;
				break;

			case IN::N:
				if (in.size > 3)
					if (in.text[in.size - 4] == '=' && in.text[in.size - 1] == IN_CODE_SPACE && in.text[in.size - 2] == MINUS || in.text[in.size - 1] == IN_CODE_SPACE && in.text[in.size - 2] == MINUS && (in.text[in.size-4] == REPEAT || in.text[in.size - 4] == COMMA || in.text[in.size - 4] == BRACKET))
						in.size--;
				in.text[in.size] = ch;
				in.size++;
				break;

			default:
				if (in.size)
					if (in.size && in.code[unsigned char(in.text[in.size - 1])] != IN::S)
					{
						in.text[in.size] = IN_CODE_SPACE;
						in.size++;
					}
				in.text[in.size] = in.code[unsigned char(ch)];
				in.size++;
				in.text[in.size] = IN_CODE_SPACE;
				in.size++;

				currentCol = 0;
				in.lines++;
			}
		}
		if (s_literal)
			throw ERROR_THROW_IN(111, in.lines, currentCol + 1);

		fin.close();

		return in;
	}

	void Delete(IN& in)
	{
		delete[] in.text;
	}
}