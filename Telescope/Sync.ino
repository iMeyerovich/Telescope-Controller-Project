void syncRaDec()
{
	syncTarget();
}

void syncTarget()
{
	if (ra != RA0 || dec != DEC0)
	{
		Serial.println("SyncInComplete");
	}
	else {
		slewTarget();
	}
}