#include <iostream>
#include <Windows.h>
#include <ctime>
#pragma warning(disable: 4996)


extern "C"
{
	int lenght(char* str)										//длина строки
	{
		return strlen(str);
	}

	int write_int(int p)											//вывод числа
	{
		std::cout << p << std::endl;
		return 0;
	}

	int write_str(char* str)										//вывод строки
	{
		setlocale(LC_ALL, "rus");
		std::cout << str << std::endl;
		return 0;
	}

	char* copy(char* str1, char* str2, int count)
	{
		int i;
		str1 = (char*)malloc(count);
		for (i = 0; i<count; i++) {
			str1[i] = str2[i];
		}
		str1[i] = '\0';
		
		return str1;
	}

	//-------------------------

	char* getLocalTimeAndDate()
	{
		time_t now = time(0);
		char* dt = ctime(&now);
		return dt;
	}

	int powNumber(int num, int num2)
	{
		return pow(num, num2);
	}

	int random(int start, int end)
	{
		srand(time(NULL));
		return rand()%end + start;
	}

	int factorialOfNumber(int num)
	{
		int res = 1;
		for (int i = 1; i <= num; i++) {
			res = res * i;
		}
		return res;
	}

	int squareOfNumber(int num)
	{
		return sqrt(num);
	}


}