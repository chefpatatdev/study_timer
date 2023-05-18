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
private:
	void dump();
	Json::Value json; //JSON object
	string path; //path for JSON file
	string date; //date for blocks reset
	int blocks; //amount of blocks studied
};

