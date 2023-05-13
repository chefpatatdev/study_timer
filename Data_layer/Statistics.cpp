#include "Statistics.h"

Statistics::Statistics() {
	char* folderpath = getenv("APPDATA");
	this->path = folderpath;
	this->path += "\\Statistics.json";
	ifstream Statisticsfile(path, ifstream::binary);
	if (Statisticsfile.good()) {
		Statisticsfile >> json;
		this->day = json["day"].asInt();
		this->year = json["year"].asInt();
		this->month = json["month"].asInt();
		this->blocks = json["blocks"].asInt();
	}
	else {
		json["day"] = 0;
		json["year"] = 0;
		json["month"] = 0;
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
	cout << this->json;
	out.close();
}
int Statistics::getDay() const {
	return this->day;
}

int Statistics::getMonth() const {
	return this->month;
}

int Statistics::getYear() const {
	return this->year;
}

int Statistics::getBlocks() const {
	return this->blocks;
}

void Statistics::setDay(int day) {
	this->day = day;
	this->json["day"] = day;
	this->dump();
}

void Statistics::setMonth(int month) {
	this->month = month;
	this->json["month"] = month;
	this->dump();
}

void Statistics::setYear(int year) {
	this->year = year;
	this->json["year"] = year;
	this->dump();
}

void Statistics::setBlocks(int blocks) {
	this->blocks = blocks;
	this->json["blocks"] = blocks;
	this->dump();
}

