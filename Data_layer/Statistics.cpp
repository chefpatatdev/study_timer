#include "Statistics.h"

Statistics::Statistics() {
	char* folderpath = getenv("APPDATA");
	this->path = folderpath;
	this->path += "\\Statistics.json";
	time_t result = time(nullptr);
	int date = result / (24 * 60 * 60);
	ifstream Statisticsfile(path, ifstream::binary);
	if (Statisticsfile.good()) {
		Statisticsfile >> json;
		if (date == json["date"].asInt()) {
			this->blocks = json["blocks"].asInt();
		}
		else {
			setBlocks(0);
		}
		setDate(date);
	}
	else {
		json["date"] = this->date;
		json["blocks"] = 0;
		ofstream out(this->path);
		out << this->json;
		out.close();
	}
	Statisticsfile.close();
}
void Statistics::dump() {
	ofstream out(this->path);
	out << this->json;
	out.close();
}
int Statistics::getDate() const {
	return this->date;
}
int Statistics::getBlocks() const {
	return this->blocks;
}

void Statistics::setDate(int date) {
	this->date = date;
	this->json["date"] = date;
	this->dump();
}

void Statistics::setBlocks(int blocks) {
	this->blocks = blocks;
	this->json["blocks"] = blocks;
	this->dump();
}

