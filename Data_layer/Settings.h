#pragma once
#include <string>
#include <iostream>
#include <fstream>
#include "json/json.h"
#include<direct.h>
using namespace std;
#pragma warning(disable : 4996)
class Settings
{
public:
	Settings();
	void setStudeerTijd(int studeertijd);
	void setPauzeTijd(int pauzetijd);
	void setPathImage(string pathImage);
	void setPathSound(string pathSound);
	void setAutoStartBreak(bool autoStartBreak);
	void setAutoStartStudy(bool autoStartStudy);

	int getStudeerTijd() const;
	int getPauzeTijd()const;
	string getPathImage() const;
	string getPathSound() const;
	bool getAutoStartBreak() const;
	bool getAutoStartStudy() const;

private:
	void dump();
	Json::Value json;
	string path;
	int studeertijd=25;
	int pauzetijd=5;
	string pathImage="";
	string pathSound="";
	bool autoStartBreak=false;
	bool autoStartStudy=false;
};

