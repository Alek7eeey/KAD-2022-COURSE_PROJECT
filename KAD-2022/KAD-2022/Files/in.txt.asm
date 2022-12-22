.586							; система команд (процессор Pentium)
.model flat, stdcall			; модель памяти, соглашение о вызовах
includelib kernel32.lib
includelib libucrt.lib
includelib StaticLib.lib

ExitProcess PROTO: dword		; прототип функции для завершения процесса Windows

EXTRN lenght_str: proc
EXTRN write_int: proc
EXTRN write_str : proc
EXTRN copy_str: proc

.stack 4096

.const							; сегмент констант - литералы
	L0 byte "he22222222222221", 0
	L1 sdword 12
	L2 byte "Helloooo, how are you?", 0
	L3 byte "Длина строки: ", 0
.data							; сегмент данных - переменные и параметры
	a_main sdword 0
	stroke_main dword ?
	lenght_main sdword 0
.code							; сегмент кода

;----------- MAIN ------------
main PROC


push offset L0
call write_str

push L1
pop a_main

mov stroke_main, offset L2
push stroke_main
call lenght_str
push eax
pop lenght_main


push offset L3
call write_str

push lenght_main
call write_int

push 0
call ExitProcess
main ENDP
end main