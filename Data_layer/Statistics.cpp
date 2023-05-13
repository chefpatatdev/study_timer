#include "Statistics.h"

Statistics::Statistics() {
	char* folderpath = getenv("APPDATA");
	this->path = folderpath;
	this->path += "\\studytimer";
	int result = mkdir(path.c_str());
	this->path += "\\Statistics.json";
	time_t timenow = time(nullptr);
	this->date = to_string(timenow / (24 * 60 * 60));
	ifstream Statisticsfile(path, ifstream::binary);
	if (Statisticsfile.good()) {
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
		json[this->date] = 0;
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

int Statistics::getBlocks() const {
	return this->blocks;
}
int Statistics::getBlocksDate(string dates) const {

	return 0;
}
void Statistics::setBlocks(int blocks) {
	this->blocks = blocks;
	this->json[this->date] = blocks;
	this->dump();
}


