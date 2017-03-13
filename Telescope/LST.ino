void doSiderealCalc() {
	// UTC calculation
	DateTime now = RTC.now();
	DateTime utcTime(now.unixtime() - TZ * 3600);
	utc = (float)utcTime.hour() + (float)utcTime.minute() / 60.0 + (float)utcTime.second() / 3600.0; // decimal form

	// calculate G (based on extrapolation)
	long g = (utcTime.year() - 2000);
	long leap = long((g + 1.0) / 4.0);                              // number of leap years since 2000
	long nleap = g - leap;                                       // number of non-leap years since 2000   
	double G = g2000 + (float)leap*lc + (float)nleap*nc;      // number of days

	// calculate nd
	double nd = doNumDays(utcTime.year(), utcTime.month(), utcTime.day());

	// calculate GST and Local Sidereal Time (LST)
	GST = G + (dc*nd) + (tc*utc) + fudge;                      // Grenwich Sidereal Time
	LSTval = GST + 24.0 + (float)(degLong/ 360 * siderealday);     // adjust for longitude (longitude portion of siderail day
	
	while (LSTval>24.0) { LSTval -= 24.0; }                          // adjust to bring into 0-24 hours
}

int doNumDays(int y, int m, int d) {
	int v = 0;
	byte leapyear = ((y - 2000) % 4 == 0) ? 1 : 0;
	switch (m) {
	case 12:  v += 30;        // Dec
	case 11:  v += 31;        // Nov
	case 10:  v += 30;        // Oct
	case 9:   v += 31;        // Sep
	case 8:   v += 31;        // Aug
	case 7:   v += 30;        // Jul
	case 6:   v += 31;        // Jun
	case 5:   v += 30;        // May
	case 4:   v += 31;        // Apr
	case 3:   v += 28 + leapyear;   // May (if year is leapyear, add extra day after February)
	case 2:   v += 31; break; // Feb
	}
	return v + d;                   // days from Jan 1 of given year
}

void getLST()
{
	doSiderealCalc();
	Serial.println(String(LSTval) + "#");
}
