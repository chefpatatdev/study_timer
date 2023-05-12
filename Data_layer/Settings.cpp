#include "Settings.h"

Settings::Settings() {
	char* folderpath = getenv("APPDATA");
	strcat(folderpath, "\\studytimer");
	int result = mkdir(folderpath);
	this->path = folderpath;
	this->path += "\\Settings.json";
	ifstream Settingsfile(path, ifstream::binary);
	if (Settingsfile.good()) {
		Settingsfile >> json;
		this->studeertijd = json["studeertijd"].asInt();
		this->pauzetijd = json["pauzetijd"].asInt();
		this->pathImage = json["pathImage"].asString();
		this->pathSound = json["pathSound"].asString();
		this->autoStartBreak = json["autoStartBreak"].asBool();
		this->autoStartStudy = json["autoStartStudy"].asBool();
	}
	else {
		this->json["studeertijd"] = getStudeerTijd();
		this->json["pauzetijd"] = getPauzeTijd();
		this->json["pathImage"] = getPathImage();
		this->json["pathSound"] = getPathSound();
		this->json["autoStartBreak"] = getAutoStartBreak();
		this->json["autoStartStudy"] = getAutoStartStudy();
		ofstream out(this->path);
		out << this->json;
		out.close();
	}
	Settingsfile.close();
}

void Settings::dump() {
	ofstream out(this->path);
	out << this->json;
	out.close();
}

void Settings::setStudeerTijd(int studeertijd) {
	this->studeertijd = studeertijd;
	this->json["studeertijd"] = this->studeertijd;
	this->dump();
}
void Settings::setPauzeTijd(int pauzetijd) {
	this->pauzetijd = pauzetijd;
	this->json["pauzetijd"] = this->pauzetijd;
	this->dump();
}
void Settings::setPathImage(string path) {
	this->pathImage = path;
	this->json["pathImage"] = this->pathImage;
	dump();
}
void Settings::setPathSound(string path) {
	this->pathSound = path;
	this->json["pathSound"] = this->pathSound;
	this->dump();
}
void Settings::setAutoStartBreak(bool autoStartBreak) {
	this->autoStartBreak = autoStartBreak;
	this->json["autoStartBreak"] = this->autoStartBreak;
	this->dump();
}
void Settings::setAutoStartStudy(bool autoStartStudy) {
	this->autoStartStudy = autoStartStudy;
	this->json["autoStartStudy"] = this->autoStartStudy;
	this->dump();
}

int Settings::getStudeerTijd() const {
	return this->studeertijd;
}

int Settings::getPauzeTijd() const {
	return this->pauzetijd;
}

string Settings::getPathImage() const {
	return this->pathImage;
}

string Settings::getPathSound() const {
	return this->pathSound;
}

bool Settings::getAutoStartBreak() const {
	return autoStartBreak;
}

bool Settings::getAutoStartStudy() const {
	return autoStartStudy;
}


