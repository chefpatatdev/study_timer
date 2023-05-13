#include "Statistics.h"

Statistics::Statistics() {
	char* folderpath = getenv("APPDATA");
	strcat(folderpath, "\\studytimer");
	this->path = folderpath;
	this->path += "\\Statistics.json";
	time_t result = time(nullptr);
	this->date = to_string(result / (24 * 60 * 60));
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
int Statistics::getBlocks(string date) const {
	return this->json[date].asInt();
}
void Statistics::setBlocks(int blocks) {
	this->blocks = blocks;
	this->json[this->date] = blocks;
	this->dump();
}


