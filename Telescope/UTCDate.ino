void displayTime()
{
	DateTime now = RTC.now();

	if (now.month()<10)
	{
		Serial.print("0");
	}
	Serial.print(now.month());
	Serial.print("/");
	if (now.day()<10)
	{
		Serial.print("0");
	}
	Serial.print(now.day());
	Serial.print("/");
	Serial.print(now.year());
	Serial.print(" ");
	if (now.hour()<10)
	{
		Serial.print("0");
	}
	Serial.print(now.hour());
	Serial.print(":");
	if (now.minute()<10)
	{
		Serial.print("0");
	}
	Serial.print(now.minute());
	Serial.print(":");
	if (now.second()<10)
	{
		Serial.print("0");
	}
	Serial.print(now.second());
	Serial.println("#");
	
	/*Serial.print(" Day of week: ");
	switch (dayOfWeek){
	case 1:
		Serial.println("Sunday");
		break;
	case 2:
		Serial.println("Monday");
		break;
	case 3:
		Serial.println("Tuesday");
		break;
	case 4:
		Serial.println("Wednesday");
		break;
	case 5:
		Serial.println("Thursday");
		break;
	case 6:
		Serial.println("Friday");
		break;
	case 7:
		Serial.println("Saturday");
		break;
	}*/
}

