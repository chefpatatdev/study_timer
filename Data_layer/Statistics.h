#pragma once
#include <string>
#include <iostream>
#include <fstream>
#include "json/json.h"
#include<direct.h>
using namespace std;
#pragma warning(disable : 4996)
class Statistics
{
public:
	Statistics();
	void setBlocks(int blocks);
	int getBlocks() const;
	int getBlocksDate(string date) const;
private:
	void dump();
	Json::Value json;
	string path;
	string date;
	int blocks; //amount of blocks studied
};

