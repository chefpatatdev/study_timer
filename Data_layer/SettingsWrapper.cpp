#include "Settings.h"
#include <comdef.h>
#include <comutil.h>

extern "C" __declspec(dllexport) Settings* CreateSettings() {
	return new Settings();
}

extern "C" __declspec(dllexport) void DeleteSettings(Settings *settings) {
	delete settings;
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

