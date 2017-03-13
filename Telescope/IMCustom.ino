#include <SparkFunAutoDriver.h>
#include <SPI.h>
#include <Wire.h>
#include "RTClib.h"
#define Pi 3.1415926
#define AzPos 711111
#define AltPos 6400

// sidereal calculation constants
#define TZ -5
#define dc 0.0657098244
#define tc 1.00273791
#define gc 6.648605
#define g2000 6.5988098
#define lc 0.0497958000000001
#define nc -0.0159140999999998
#define fudge -0.013922				 // fudge factor
#define siderealday 23.9344699       // length of sidereal day (23:56:04)
DS3231 RTC;

#define RA0 0.0
#define DEC0 0.0

double GST, LSTval, utc;
boolean parked, tracking, slewing;
float degLat, degLong, lha, ra, dec, altitude, azimuth;

AutoDriver azBoard(23, 22); //FWD = CCW, REV = CW
AutoDriver altBoard(27, 26); //FWD = 0, REV = 90

void setup()
{
	Wire.begin();
	Serial.begin(9600);
	Serial.flush();
	dSPINConfig();
	setPark();
	parked = true;
	tracking = false;
	slewing = false;
	degLat = 41.333563;
	degLong = -72.945701;
	ra = 0.0;
	dec = 0.0;
}

void loop()
{ 
	String input;
	if (Serial.available() > 0) {
		input = Serial.readStringUntil('#');
		Options(input);
	}
	if (tracking && !slewing && !parked){
		track();
	}
}

void Options(String input){
	if (input == "getUTCDate")
		displayTime();
	else if (input == "Can")
		Can();
	else if (input == "AbortSlew")
		AbortSlew();
	else if (input == "moveAxis")
		moveAxis();
	else if (input == "setPark")
		setPark();
	else if (input == "park")
		park();
	else if (input == "unPark")
		unPark();
	else if (input == "getParkState")
		getParkState();
	else if (input == "setTracking")
		setTracking();
	else if (input == "getTracking")
		getTracking();
	else if (input == "setLat")
		setLat();
	else if (input == "setLong")
		setLong();
	else if (input == "getLat")
		getLat();
	else if (input == "getLong")
		getLong();
	else if (input == "getLST")
		getLST();
	else if (input == "setDec")
		setDec();
	else if (input == "setRA")
		setRA();
	else if (input == "getDec")
		getDec();
	else if (input == "getRA")
		getRA();
	else if (input == "getSlew")
		getSlew();
	else if (input == "slewAzAlt")
		slewAzAlt();
	else if (input == "slewRaDec")
		slewRaDec();
	else if (input == "slewTarget")
		slewTarget();
	else if (input == "syncRaDec")
		syncRaDec();
	else if (input == "syncTarget")
		syncTarget();
}

void Can()
{
	String tmp = Serial.readStringUntil('#');
	if (tmp == "Sync")
		Serial.println("true");
}