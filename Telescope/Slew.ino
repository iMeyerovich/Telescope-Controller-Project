void AbortSlew()
{
	altBoard.softStop();
	azBoard.softStop();
}

void setRA()
{
	String raPos = "";

	raPos = Serial.readStringUntil('#');
	ra = raPos.toDouble();
}

void setDec()
{
	String decPos = "";

	decPos = Serial.readStringUntil('#');
	dec = decPos.toDouble();
}

void getRA()
{
	Serial.println(String(ra));
}

void getDec()
{
	Serial.println(String(dec));
}

void getSlew()
{
	Serial.println(String(slewing));
}

void slewAzAlt()
{
	slewing = true;
	String altPos = "";
	String azPos = "";

	azPos = Serial.readStringUntil('#');
	altPos = Serial.readStringUntil('#');
	azimuth = azPos.toDouble();
	altitude = altPos.toDouble();

	int azCoor = ((AzPos*azimuth) / 360);
	int altCoor = ((AltPos*altitude) / 360);

	azBoard.goTo(azCoor);
	altBoard.goTo(altCoor);

	while (slewing = true){
		if (azBoard.getPos() == azCoor && altBoard.getPos() == altCoor){
			slewing = false;
			Serial.println("SlewComplete#");
		}
		//String input = Serial.readStringUntil('#');
		//Options(input);
	}
}

void slewRaDec()
{
	String raPos = "";
	String decPos = "";

	raPos = Serial.readStringUntil('#');
	decPos = Serial.readStringUntil('#');
	ra = raPos.toDouble();
	dec = decPos.toDouble();

	slewTarget();
}

void slewTarget()
{
	slewing = true;

	raDecConversion();

	int azCoor = ((AzPos*azimuth) / 360);
	int altCoor = ((AltPos*altitude) / 360);

	azBoard.goTo(azCoor);
	altBoard.goTo(altCoor);

	while (slewing = true){
		if (azBoard.getPos() == azCoor && altBoard.getPos() == altCoor){
			raDecConversion();

			int azCoor = ((AzPos*azimuth) / 360);

			azBoard.goTo(azCoor);

			slewing = false;
			Serial.println("SlewComplete#");
		}
		//String input = Serial.readStringUntil('#');
		//Options(input);
	}
}