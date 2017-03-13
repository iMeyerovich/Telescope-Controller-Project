void moveAxis()
{
	String axisIn = "";
	String rateIn = "";
	double rate;

	axisIn = Serial.readStringUntil('#');
	rateIn = Serial.readStringUntil('#');
	rate = rateIn.toDouble();
	
	
		if (axisIn == "axisPrimary"){
			if (abs(rate) > azBoard.getMaxSpeed())
			{
				if (rate < 0)
					rate = azBoard.getMaxSpeed()*-1;
				else
					rate = azBoard.getMaxSpeed();
			}
			if (rate > 0)
				azBoard.run(FWD, rate);
			else if (rate < 0)
				azBoard.run(REV, abs(rate));
			else
				azBoard.softStop();
		}
		else if (axisIn == "axisSecondary"){
			if (abs(rate) > altBoard.getMaxSpeed())
			{
				if (rate < 0)
					rate = altBoard.getMaxSpeed()*-1;
				else
					rate = altBoard.getMaxSpeed();
			}
			if (rate > 0)
				altBoard.run(FWD, rate);
			else if (rate < 0)
				altBoard.run(REV, abs(rate));
			else
				altBoard.softStop();
		}
}
