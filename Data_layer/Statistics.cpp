#include "Statistics.h"

Statistics::Statistics() {
	//set date from file
	/*setDay(day);
	setMonth(month);
	setYear(year);
	setBlocks(blocks);*/

	//default values for testing purpouses
	setDay(1);
	setMonth(1);
	setYear(2023);
	setBlocks(4);
}

int Statistics::getDay() const{
	return this->day;
}

int Statistics::getMonth() const{
	return this->month;
}

int Statistics::getYear() const{
	return this->year;
}

int Statistics::getBlocks() const{
	return this->blocks;
}

void Statistics::setDay(int day) {
	this->day = day;
}

void Statistics::setMonth(int month) {
	this->month = month;
}

void Statistics::setYear(int year) {
	this->year = year;
}

void Statistics::setBlocks(int blocks) {
	this->blocks = blocks;
}

