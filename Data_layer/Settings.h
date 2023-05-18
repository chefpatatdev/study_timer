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
	Json::Value json; //JSON object
	string path; //path for JSON file
	int studeertijd=25; //default values as the pomodoro techinique describes
	int pauzetijd=5;
	string pathImage=""; //path for background image
	string pathSound=""; //path for notification sound
	bool autoStartBreak=false;
	bool autoStartStudy=false;
};

