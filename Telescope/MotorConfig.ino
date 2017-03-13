void dSPINConfig(void)
{
	azBoard.configSyncPin(BUSY_PIN, 0);		     // BUSY pin low during operations;

	azBoard.configStepMode(STEP_FS_8);          // 16 microsteps per step
	azBoard.setMaxSpeed(400);                    // 400 steps/s (2 RPS) (max of motor)
	azBoard.setFullSpeed(100);                   // microstep below 100 steps/s (0.5 RPS)
	azBoard.setAcc(600);                         // accelerate at 600 steps/s/s (Gear train ensures slow speeds even at full speed)
	azBoard.setDec(600);
	azBoard.setSlewRate(SR_530V_us);             // Max speed for max torque
	azBoard.setOCThreshold(OC_750mA);            // OC threshold 750mA
	azBoard.setPWMFreq(PWM_DIV_2, PWM_MUL_2);    // 31.25kHz PWM freq
	azBoard.setOCShutdown(OC_SD_DISABLE);        // shutdown on OC
	azBoard.setVoltageComp(VS_COMP_ENABLE);     // don't compensate for motor V
	azBoard.setSwitchMode(SW_HARD_STOP);         // Switch is hard stop
	azBoard.setOscMode(INT_16MHZ_OSCOUT_16MHZ);

	azBoard.setAccKVAL(255);
	azBoard.setDecKVAL(255);
	azBoard.setRunKVAL(255);
	azBoard.setHoldKVAL(32);

	altBoard.configSyncPin(BUSY_PIN, 0);	      // BUSY pin low during operations;

	altBoard.configStepMode(STEP_FS_32);          // 32 microsteps per step
	altBoard.setMaxSpeed(8);                     // 10 steps/s (0.1 RPS) (Limited ROM demands slower speeds for safety)
	altBoard.setFullSpeed(8);                    // microstep below 11 steps/s (Always Microstep)
	altBoard.setAcc(8);                           // accelerate at 10 steps/s/s (1:1 Gearing requires gentler start and stop)
	altBoard.setDec(8);
	altBoard.setSlewRate(SR_530V_us);             // Max speed for max torque
	altBoard.setOCThreshold(OC_750mA);            // OC threshold 750mA
	altBoard.setPWMFreq(PWM_DIV_2, PWM_MUL_2);    // 31.25kHz PWM freq
	altBoard.setOCShutdown(OC_SD_ENABLE);         // shutdown on OC
	altBoard.setVoltageComp(VS_COMP_ENABLE);     // don't compensate for motor V
	altBoard.setSwitchMode(SW_HARD_STOP);         // Switch is hard stop
	altBoard.setOscMode(INT_16MHZ_OSCOUT_16MHZ);

	altBoard.setAccKVAL(255);
	altBoard.setDecKVAL(255);
	altBoard.setRunKVAL(255);
	altBoard.setHoldKVAL(32);
}
