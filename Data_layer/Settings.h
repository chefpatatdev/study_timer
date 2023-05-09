#pragma once
#include <string>
using namespace std;

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
	int studeertijd;
	int pauzetijd;
	string pathImage;
	string pathSound;
	bool autoStartBreak;
	bool autoStartStudy;
};

