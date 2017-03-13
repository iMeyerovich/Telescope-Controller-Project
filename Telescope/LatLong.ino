void setLat()
{
	String tmp;

	tmp = Serial.readStringUntil('#');
	degLat = tmp.toFloat();
}

void getLat()
{
	Serial.println(String(degLat)+"#");
}

void setLong()
{
	String tmp;

	tmp = Serial.readStringUntil('#');
	degLong = tmp.toFloat();
}

void getLong()
{
	Serial.println(String(degLong) + "#");
}
