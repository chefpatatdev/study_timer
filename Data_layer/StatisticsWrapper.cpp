#include "Statistics.h"

extern "C" __declspec(dllexport) Statistics * CreateStatistics() {
	return new Statistics();
}

extern "C" __declspec(dllexport) void DeleteStatistics(Statistics * statistics) {
	delete statistics;
}

extern "C" __declspec(dllexport) int GetDay(Statistics * statistics) {
	return statistics->getDay();
}

extern "C" __declspec(dllexport) void SetDay(Statistics * statistics, int day) {
	statistics->setDay(day);
}

extern "C" __declspec(dllexport) int GetMonth(Statistics * statistics) {
	return statistics->getMonth();
}

extern "C" __declspec(dllexport) void SetMonth(Statistics * statistics, int month) {
	statistics->setMonth(month);
}

extern "C" __declspec(dllexport) int GetYear(Statistics * statistics) {
	return statistics->getYear();
}

extern "C" __declspec(dllexport) void SetYear(Statistics * statistics, int year) {
	statistics->setYear(year);
}

extern "C" __declspec(dllexport) int GetBlocks(Statistics * statistics) {
	return statistics->getBlocks();
}

extern "C" __declspec(dllexport) void SetBlocks(Statistics * statistics, int blocks) {
	statistics->setBlocks(blocks);
}