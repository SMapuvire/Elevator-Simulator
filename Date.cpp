#include "Date.h"
#include <ctime>
#include <stdlib.h>

//Constructors
//Date array order = |Hour|Day|Month|Year|
Date::Date()
{
	Reset();
}
Date::Date(float seed)
{
	Randomiser(seed);
}
Date::Date(int hr, int dy, int mnth, int yr)
{
	/*
	To translate to C# could just
	declare current_date as a DateTime object.
	Then set start_date as same as current_date.
	*/

	current_date[0] = hr;
	current_date[1] = dy;
	current_date[2] = mnth;
	current_date[3] = yr;

	for (int i = 0; i < 4; i++)
	{
		start_date[i] = current_date[i];
	}
}

//Mutator
////////////////////////////////////////////////////////////
void Date::Set_Date(int hr, int dy, int mnth,int yr, char reset_start)
{
	/*
	In C# assume current_date is DateTime object.
	*/

	current_date[0] = hr;
	current_date[1] = dy;
	current_date[2] = mnth;
	current_date[3] = yr;

	/*
	Decide whether to keep starting date, for predictive mode,
	or to reset the start date, for regular mode
	*/
	if (reset_start == 'y' || reset_start == 'Y')
	{
		for (int i = 0; i < 4; i++)
		{
			start_date[i] = current_date[i];
		}
	}
}

//Accessor
int* Date::Get_Date()
{
	/*
	In C# assume current_date is DateTime object and simply return that
	*/
	return current_date;
}

int* Date::Duration()
{
	int difference[4];
	/*
	In C# assume current_date & start_date are DateTime object.
	Then Use ((Current_date - Start_date).Days)	
	*/
	return difference;
}

//Updater
void Date::Update()
{
	/*
	To translate to C# could just
	assume current_date is a DateTime object.
	*/

	//Increment hour
	current_date[0]++;

	//Increment day check
	if (current_date[0] == 24)
	{
		current_date[0] = 0;
		current_date[1]++;
	}

	//Increment month check
	switch (current_date[2])
	{
	case 2:
		if (current_date[1] == 29)
		{
			current_date[0] = 0;
			current_date[1] = 1;
			current_date[2]++;
			break;
		}

	case 4: case 7: case 9: case 11:
		if (current_date[1] == 31)
		{
			current_date[0] = 0;
			current_date[1] = 1;
			current_date[2]++;
			break;
		}

	default:
		if (current_date[1] == 32)
		{
			current_date[0] = 0;
			current_date[1] = 1;
			current_date[2]++;
		}
	}

	//Increment year check
	if (current_date[2] == 13)
	{
		current_date[0] = 0;
		current_date[1] = 1;
		current_date[2] = 1;
		current_date[3]++;
	}
}

//////////////
//Look over
/////////////
void Date::Randomiser(float seed)
{
	/*
	To translate to C# could just
	declare current_date as a DateTime object.
	*/

	srand(seed);

	//Assign hour
	current_date[0] = (abs(rand()) % 23) + 1;
	//Assign Month
	current_date[2] = (abs(rand()) % 12) + 1;
	//Assign year
	current_date[3] = (abs(rand()) % 4) + 1;

	//Choose appropriate day range based on month
	switch (current_date[2])
	{
	//February
	case 2:
		if (current_date[3] % 4 == 0)
		{
			current_date[1] = (abs(rand()) % 29) + 1;
		}
		else
		{
			current_date[1] = (abs(rand()) % 28) + 1;
		}
		break;

	//April, July, September, November
	case 4: case 7: case 9: case 11:
		current_date[1] = (abs(rand()) % 30) + 1;
		break;

	//Other months
	default:
		current_date[1] = (abs(rand()) % 31) + 1;
	}
}
void Date::Reset()
{
	/*
	To translate to C# could just 
	declare current_date as a DateTime object. 
	Then set start_date as same as current_date.
	*/

	//Hour
	current_date[0] = 0;
	//Day
	current_date[1] = 1;
	//Month
	current_date[2] = 1;
	//Year
	current_date[3] = 1;

	for (int i = 0; i < 4; i++)
	{
		start_date[i] = current_date[i];
	}
}

Date::~Date()
{

}