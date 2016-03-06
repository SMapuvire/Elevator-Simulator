#pragma once
/*
This class uses current_date and start_date as arrays.
In C#, they can instead be represented as DateTime objects.
So all functions that are type int* need to return DateTime objects
Also the actual functions need to work with DateTime objects
*/
class Date
{
public:
	//Sets date to beginning of calendar
	Date();
	//Uses Randomiser to create starting date
	Date(float seed);
	//User-input date
	Date(int hr, int day, int mnth, int yr);
	
	//Destructor
	~Date();

	//Generates a random date 
	void Randomiser(float seed);
	//Set date back to day 1
	void Reset();
	
	/*
	Alternate means of setting user decided date
	*****************************************************
	Variable "reset_date" takes 'Y'/'y' and 'N'/'n' signifying 
	whether to keep starting date, for predictive mode,	
	or to reset the start date, for regular mode
	*/
	void Set_Date(int hr, int dy, int mnth, int yr, char reset_date);
	//Return a pointer to the current date array
	int* Get_Date();
	//Return a pointer to an array representing the duration
	int* Duration();
	
	//Updated at regular interval decided in main program
	void Update();

private:
	//Array = hour, day, month, year
	int current_date[4], start_date[4];
};

