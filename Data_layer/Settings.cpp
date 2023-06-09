#include "Settings.h"

/**
*	Purpouse: Settings object with getters and setters. Also saving the data to a specific JSON file for settings.
*	@author Ricky Da Silva Marques & Thomas Ocket
*/

/*
	Constructor of the Settings class that creates a JSON file if it doenst exist yet. 
	It gets predefined values from the header file if the JSON doesnt exist. If it does, 
	it gets all the values from the Json and places them in the Settings object.
*/

Settings::Settings() { //Thomas Ocket
	//Creates a path and folder for the JSON file to be placed in Appdata.
	char* folderpath = getenv("APPDATA");
	this->path = folderpath;
	this->path += "\\studytimer";
	int result = mkdir(path.c_str());
	this->path += "\\Settings.json";

	//Checks if Settings JSON file exists on that path, if so set the values from it to Settings object.
	//Else create a JSON with default values.
	ifstream Settingsfile(path, ifstream::binary);
	if (Settingsfile.good()) { //reading contents of JSON file
		Settingsfile >> json;
		this->studeertijd = json["studeertijd"].asInt();
		this->pauzetijd = json["pauzetijd"].asInt();
		this->pathImage = json["pathImage"].asString();
		this->pathSound = json["pathSound"].asString();
		this->autoStartBreak = json["autoStartBreak"].asBool();
		this->autoStartStudy = json["autoStartStudy"].asBool();
	}
	else { //writing default values to JSON file
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

//Write the JSON object to the JSON file
void Settings::dump() { //Thomas Ocket
	ofstream out(this->path);
	out << this->json; //writes contents of JSON object to the JSON file
	out.close();
}

/*
	These functions behave in a simular way to a normal setter with the only differnce that after setting the object value,
	the JSON file gets updated with the set value.

	@author Ricky Da Silva Marques & Thomas Ocket
*/

void Settings::setStudeerTijd(int studeertijd) {
	this->studeertijd = studeertijd;
	this->json["studeertijd"] = this->studeertijd; //write to JSON object
	this->dump(); //export the JSON object to the file
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

/*
	readonly getters
	@author Ricky Da Silva Marques
*/

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


