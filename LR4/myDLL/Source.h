#pragma once

#ifdef MATHLIBRARY_EXPORTS
#define MATHLIBRARY_API __declspec(dllexport)
#else
#define MATHLIBRARY_API __declspec(dllimport)
#endif

extern "C"
{
    MATHLIBRARY_API int _stdcall Sum(int firstValue, int secondValue);
    MATHLIBRARY_API int _stdcall Subtract(int firstValue, int secondValue);
    MATHLIBRARY_API int _stdcall Multiply(int firstValue, int secondValue);
    MATHLIBRARY_API int _stdcall Divide(int firstValue, int secondValue);
    MATHLIBRARY_API int _stdcall Mod(int firstValue, int secondValue);
    MATHLIBRARY_API int _stdcall Abs(int value);
    MATHLIBRARY_API int __cdecl Pow(int firstValue, int secondValue);
    MATHLIBRARY_API int __cdecl Min(int firstValue, int secondValue);
    MATHLIBRARY_API int __cdecl Max(int firstValue, int secondValue);
}