#include "Statistics.h"

/**
*	Purpouse: Statistics object with getters and setters. Also saving the data to a specific JSON file for statistics.
*	@author Thomas Ocket
*/

Statistics::Statistics() {
	//Creates a path and folder for the JSON file to be placed in Appdata.
	char* folderpath = getenv("APPDATA");
	this->path = folderpath;
	this->path += "\\studytimer";
	int result = mkdir(path.c_str());
	this->path += "\\Statistics.json";

	//Gets the current day so we can check if its a new day, this is used to reset the blocks counter of a day.
	time_t timenow = time(nullptr);
	this->date = to_string(timenow / (24 * 60 * 60));

	//Checks if Statistics JSON file exists on that path, else create one.
	ifstream Statisticsfile(path, ifstream::binary);
	if (Statisticsfile.good()) { 
		//if JSON exist check if current day already exist in the file.
		//When current day exist get the blocks and set it in the Settings object, else set blocks to 0 with new day.
		Statisticsfile >> json;
		cout << json[this->date] << endl;
		if (json[this->date] != NULL) {
			this->blocks = json[this->date].asInt();
		}
		else {
			setBlocks(0);
		}
	}
	else {
		//When JSON doesnt exist create one with the current day and blocks = 0
		json[this->date] = 0;
		ofstream out(this->path);
		out << this->json;
		out.close();
	}
	Statisticsfile.close();
}

//Write the JSON object to the JSON file
void Statistics::dump() {
	ofstream out(this->path);
	out << this->json; //Writes contents of JSON object to the JSON file
	out.close(); 
}

int Statistics::getBlocks() const {
	return this->blocks;
}

void Statistics::setBlocks(int blocks) {
	this->blocks = blocks;
	this->json[this->date] = blocks; //Write to JSON object
	this->dump(); //Export the JSON object to the file
}


