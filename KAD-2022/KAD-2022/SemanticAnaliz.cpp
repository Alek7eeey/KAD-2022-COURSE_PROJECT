#include "stdafx.h"
#include "SemanticAnaliz.h"
#include "Error.h"

using namespace std;

namespace SM
{
	void semAnaliz(LT::LexTable& lextable, IT::IdTable& idtable)
	{
		for (int i = 0; i < lextable.current_size; i++)
		{
			switch (lextable.table[i]->lexema)
			{
			case LEX_OPERATOR:	// деление на 0
			{
				if (lextable.table[i]->sign == '/')
					if (lextable.table[i + 1]->lexema == LEX_LITERAL)
					{
						if (idtable.table[lextable.table[i + 1]->idxTI]->value.vint == 0)
							throw ERROR_THROW_IN(700, lextable.table[i + 1]->sn, lextable.table[i + 1]->tn);
					}
				break;
			}
			case LEX_EQUAL: // выражение
			{
				if (i)
				{
					IT::IDDATATYPE lefttype = idtable.table[lextable.table[i - 1]->idxTI]->iddatatype;	// левый операнд
					bool ignore = false;

					for (int k = i + 1; lextable.table[k]->lexema != LEX_SEMICOLON; k++)
					{
						if (lextable.table[k]->idxTI != LT_TI_NULLXDX) // если ид - проверить совпадение типов
						{
							if (!ignore)
							{
								IT::IDDATATYPE righttype = idtable.table[lextable.table[k]->idxTI]->iddatatype;
								if (lefttype != righttype) // типы данных в выражении не совпадают
									throw ERROR_THROW_IN(701, lextable.table[k]->sn, -1);
							}
							// если лексема сразу после идентиф скобка - это вызов функции
							if (k + 1 < lextable.current_size && lextable.table[k + 1]->lexema == LEX_LEFTHESIS && idtable.table[lextable.table[k]->idxTI]->idtype == IT::IDTYPE::F)
							{
								ignore = true;
								continue;
							}
							// закрывающа€ скобка после списка параметров
							if (ignore && lextable.table[k + 1]->lexema == LEX_RIGHTHESIS)
							{
								ignore = false;
								continue;
							}
						}
						if (lefttype == IT::IDDATATYPE::STR) // справа только литерал, ид или вызов строковой ф-ции
						{
							char l = lextable.table[k]->lexema;
							if (l == LEX_OPERATOR) // выражени€ недопустимы
								throw ERROR_THROW_IN(702, lextable.table[k]->sn, -1);
						}
					}
				}
				break;
			}
			case LEX_ID: // проверка типа возвращаемого значени€  
			{
				IT::Entry* e;
					e = idtable.table[lextable.table[i]->idxTI];

				if (i && lextable.table[i - 1]->lexema == LEX_FUNCTION)	// объ€вление функции
				{
					for (int k = i + 1; ; k++)
					{
						char l = lextable.table[k]->lexema;
						if (l == LEX_RETURN)
						{
							int next = lextable.table[k + 1]->idxTI; // след. за return
							if (idtable.table[next]->iddatatype != e->iddatatype)
								throw ERROR_THROW_IN(703, lextable.table[k + 1]->sn, -1);
							break;
						}
					}
				}
				if (lextable.table[i + 1]->lexema == LEX_LEFTHESIS && lextable.table[i - 1]->lexema != LEX_FUNCTION) // именно вызов
				{
					if (e->idtype == IT::IDTYPE::F) // точно функци€
					{
						int paramscount = NULL;
						// проверка передаваемых параметров
						for (int j = i + 1; lextable.table[j]->lexema != LEX_RIGHTHESIS; j++)
						{
							// проверка соответстви€ передаваемых параметров прототипам
							if (lextable.table[j]->lexema == LEX_ID || lextable.table[j]->lexema == LEX_LITERAL)
							{
								paramscount++;
								IT::IDDATATYPE ctype = idtable.table[lextable.table[j]->idxTI]->iddatatype;
								if (paramscount > e->params.count)
									throw ERROR_THROW_IN(705, lextable.table[i]->sn, -1);
								if (ctype != e->params.types[paramscount - 1])
									throw ERROR_THROW_IN(704, lextable.table[j]->sn, lextable.table[j]->tn);
							}
						}
						if (paramscount != e->params.count)
							throw ERROR_THROW_IN(705, lextable.table[i]->sn, -1);
					}
				}
				break;
			}
			case LEX_MORE:	case LEX_LESS:
			{
				// левый и правый операнд - числовой тип
				bool flag = true;
				if (lextable.table[i - 1]->idxTI != LT_TI_NULLXDX)
				{
					if (idtable.table[lextable.table[i - 1]->idxTI]->iddatatype != IT::IDDATATYPE::INT)
						flag = false;
				}
				if (lextable.table[i + 1]->idxTI != LT_TI_NULLXDX)
				{
					if (idtable.table[lextable.table[i + 1]->idxTI]->iddatatype != IT::IDDATATYPE::INT)
						flag = false;
				}
				if (!flag)
					throw ERROR_THROW_IN(706, lextable.table[i]->sn, -1);
				break;
			}
			}
		}
	}
}