#include "Settings.h"
#include <comdef.h>
#include <comutil.h>

/**
*	Purpouse: Export the functions to use the Settings object in C# with P/invoke. 
*	@author Ricky Da Silva Marques
*	@param *settings An object pointer given by C#
*/

extern "C" __declspec(dllexport) Settings* CreateSettings() {
	return new Settings(); //Returning the object pointer on creation of a new object
}

extern "C" __declspec(dllexport) void DeleteSettings(Settings *settings) {
	delete settings; //destructor to prevent memory leaks
}

extern "C" __declspec(dllexport) int GetStudeerTijd(Settings * settings) {
	return settings->getStudeerTijd();
}

extern "C" __declspec(dllexport) void SetStudeerTijd(Settings * settings, int studeertijd) {
	settings->setStudeerTijd(studeertijd);
}

extern "C" __declspec(dllexport) int GetPauzeTijd(Settings * settings) {
	return settings->getPauzeTijd();
}

extern "C" __declspec(dllexport) void SetPauzeTijd(Settings * settings, int pauzetijd) {
	settings->setPauzeTijd(pauzetijd);
}

extern "C" __declspec(dllexport) BSTR GetPathImage(Settings * settings) {
	//converting and using BSTR as unmanaged datatype for string, C# knows it will recieve a BSTR.
	return _com_util::ConvertStringToBSTR(settings->getPathImage().c_str());
}

extern "C" __declspec(dllexport) void SetPathImage(Settings * settings, const char* path) {
	settings->setPathImage(path);
}

extern "C" __declspec(dllexport) BSTR GetPathSound(Settings * settings) {
	return _com_util::ConvertStringToBSTR(settings->getPathSound().c_str());
}

extern "C" __declspec(dllexport) void SetPathSound(Settings * settings, const char* path) {
	settings->setPathSound(path);
}

extern "C" __declspec(dllexport) bool GetAutoStartBreak(Settings * settings) {
	return settings->getAutoStartBreak();
}

extern "C" __declspec(dllexport) void SetAutoStartBreak(Settings * settings, bool autoStartBreak) {
	settings->setAutoStartBreak(autoStartBreak);
}

extern "C" __declspec(dllexport) bool GetAutoStartStudy(Settings * settings) {
	return settings->getAutoStartStudy();
}

extern "C" __declspec(dllexport) void SetAutoStartStudy(Settings * settings, bool autoStartStudy) {
	settings->setAutoStartStudy(autoStartStudy);
}

