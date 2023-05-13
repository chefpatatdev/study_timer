#include "Statistics.h"
using namespace std;
extern "C" __declspec(dllexport) Statistics * CreateStatistics() {
	return new Statistics();
}

extern "C" __declspec(dllexport) void DeleteStatistics(Statistics * statistics) {
	delete statistics;
}


extern "C" __declspec(dllexport) int GetBlocks(Statistics * statistics) {
	return statistics->getBlocks();
}
/*
extern "C" __declspec(dllexport) int GetBlocksDate(Statistics * statistics,string date) {
	return statistics->getBlocksDate(date);
}
*/

extern "C" __declspec(dllexport) void SetBlocks(Statistics * statistics, int blocks) {
	statistics->setBlocks(blocks);
}