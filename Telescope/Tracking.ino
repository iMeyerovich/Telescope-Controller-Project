 void setTracking()
{
	String trackstate;
	trackstate = Serial.readStringUntil('#');
	if (trackstate == "true"){
		tracking = true;
		track();
	}
	else{
		tracking = false;
		AbortSlew();
	}
}

void getTracking()
{
	Serial.println(String(tracking) + "#");
}

void track()
{
	azBoard.run(REV, 1.031623);
	raDecConversion();
	altitude = ((AltPos*altitude) / 360)*-1;
	altBoard.goTo(altitude);
}

void raDecConversion()
{
	LHA();

	float radRa = ra*PI/180;
	float radDec = dec*PI / 180;
	float radLha = lha*PI / 180;
	float radLat = degLat*PI / 180;

	float prealt = (sin(radDec)*sin(radLat)) + (cos(radDec)*cos(radLat)*cos(radLha));
	altitude = asin(prealt) * 180 / PI;

	float radAlt = altitude*PI / 180;

	float preaz = (sin(radDec) - sin(radAlt)*sin(radLat)) / (cos(radAlt)*cos(radLat));
	if (sin(radLha) < 0){
		azimuth = acos(preaz) * 180 / PI;
	}
	else {
		azimuth = 360 - (acos(preaz) * 180 / PI);
	}
}

void LHA()
{
	doSiderealCalc();
	lha = LSTval - ra;
	if (lha < 0){
		lha = lha + 360;
	}
}