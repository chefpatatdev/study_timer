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
	void setDay(int day);
	void setMonth(int month);
	void setYear(int year);
	void setBlocks(int blocks);


	int getDay() const;
	int getMonth() const;
	int getYear() const;
	int getBlocks() const;
private:
	void dump();
	Json::Value json;
	string path;
	int day;
	int month;
	int year;
	int blocks; //amount of blocks studied
};

