#include "Statistics.h"

extern "C" __declspec(dllexport) Statistics * CreateStatistics() {
	return new Statistics();
}

extern "C" __declspec(dllexport) void DeleteStatistics(Statistics * statistics) {
	delete statistics;
}

extern "C" __declspec(dllexport) int GetDate(Statistics * statistics) {
	return statistics->getDate();
}

extern "C" __declspec(dllexport) void SetDate(Statistics * statistics, int date) {
	statistics->setDate(date);
}

extern "C" __declspec(dllexport) int GetBlocks(Statistics * statistics) {
	return statistics->getBlocks();
}

extern "C" __declspec(dllexport) void SetBlocks(Statistics * statistics, int blocks) {
	statistics->setBlocks(blocks);
}