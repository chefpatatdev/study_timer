#include "Settings.h"

Settings::Settings() {
	/*hier file inlezen en ze zetten met setters
	setStudeerTijd(studeertijd);
	setPauzeTijd(pauzetijd);
	setPathImage(pathImage);
	setPathSound(pathSound);
	setAutoStartBreak(autoStartBreak);
	setAutoStartStudy(autoStartStudy);*/


	//voorlopige standaard waarden om te testen
	this->autoStartBreak = false;
	this->autoStartStudy = false;
	this->pathImage = "";
	this->pathSound = "";
	this->pauzetijd = 5;
	this->studeertijd = 25;

}

void Settings::setStudeerTijd(int studeertijd) {
	this->studeertijd = studeertijd;
}
void Settings::setPauzeTijd(int pauzetijd) {
	this->pauzetijd = pauzetijd;
}
void Settings::setPathImage(string path) {
	this->pathImage = path;
}
void Settings::setPathSound(string path) {
	this->pathSound = pathSound;
}
void Settings::setAutoStartBreak(bool autoStartBreak) {
	this->autoStartBreak = autoStartBreak;
}
void Settings::setAutoStartStudy(bool autoStartStudy) {
	this->autoStartStudy = autoStartStudy;
}

int Settings::getStudeerTijd() const{
	return this->studeertijd;
}

int Settings::getPauzeTijd() const{
	return this->pauzetijd;
}

string Settings::getPathImage() const{
	return this->pathImage;
}

string Settings::getPathSound() const {
	return this->pathSound;
}

bool Settings::getAutoStartBreak() const{
	return autoStartBreak;
}

bool Settings::getAutoStartStudy() const {
	return autoStartStudy;
}


