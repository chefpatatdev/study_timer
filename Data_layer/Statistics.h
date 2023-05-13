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
	void setDate(int date);
	void setBlocks(int blocks);


	int getDate() const;
	int getBlocks() const;
private:
	void dump();
	Json::Value json;
	string path;
	int date;
	int blocks; //amount of blocks studied
};

