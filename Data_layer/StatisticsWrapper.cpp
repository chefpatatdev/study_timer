#include "Statistics.h"
using namespace std;

/**
*	Purpouse: Export the functions to use the Statistics object in C# with P/invoke.
*	@author Ricky Da Silva Marques
*	@param *settings An object pointer given by C#
*/

extern "C" __declspec(dllexport) Statistics * CreateStatistics() {
	return new Statistics(); //Returning the object pointer on creation of a new object
}

extern "C" __declspec(dllexport) void DeleteStatistics(Statistics * statistics) {
	delete statistics; //destructor to prevent memory leaks
}

extern "C" __declspec(dllexport) int GetBlocks(Statistics * statistics) {
	return statistics->getBlocks();
}

extern "C" __declspec(dllexport) void SetBlocks(Statistics * statistics, int blocks) {
	statistics->setBlocks(blocks);
}