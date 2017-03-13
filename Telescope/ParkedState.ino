void setPark()
{
	azBoard.setMark(0);
	altBoard.setMark(0);
}

void park()
{
	azBoard.goMark();
	altBoard.goMark();
	parked = true;
}

void unPark() 
{
	if (tracking){
		track();
	}
	parked = false;
}

void getParkState()
{
	Serial.println(String(parked)+"#");
}