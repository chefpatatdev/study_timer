#pragma once
class Statistics
{
public:
	Statistics();
	void setDay(int day);
	void setMonth(int month);
	void setYear(int year);
	void setBlocks(int blocks);


	int getDay() const;
	int getMonth() const;
	int getYear() const;
	int getBlocks() const;
private:
	int day;
	int month;
	int year;
	int blocks; //amount of blocks studied
};

