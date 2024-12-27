#include <DynamixelShield.h>

#if defined(ARDUINO_AVR_UNO) || defined(ARDUINO_AVR_MEGA2560)
  #include <SoftwareSerial.h>

  SoftwareSerial soft_serial(7, 8);
  #define DEBUG_SERIAL soft_serial

#elif defined(ARDUINO_SAM_DUE) || defined(ARDUINO_SAM_ZERO)
  #define DEBUG_SERIAL SerialUSB

#else
  #define DEBUG_SERIAL Serial

#endif

const uint8_t DXL_ID1 = 3;
const float DXL_PROTOCOL_VERSION = 1.0;

DynamixelShield dxl;

using namespace ControlTableItem;

void setup() 
{
  DEBUG_SERIAL.begin(115200);
  
  dxl.begin(1000000);
  dxl.setPortProtocolVersion(DXL_PROTOCOL_VERSION);
  
  dxl.ping(DXL_ID1);
  dxl.torqueOff(DXL_ID1);
  dxl.setOperatingMode(DXL_ID1, OP_POSITION);
  dxl.setGoalPosition(DXL_ID1, 0, UNIT_DEGREE);
  delay(1000);
  dxl.setOperatingMode(DXL_ID1, OP_VELOCITY);
  dxl.torqueOn(DXL_ID1);
}

void loop() 
{
  if(DEBUG_SERIAL.available() > 0)
  {
    String inputRPM = DEBUG_SERIAL.readString();

    String strRPM1 = inputRPM.substring(0, inputRPM.indexOf(","));
    String strRPM2 = inputRPM.substring(inputRPM.indexOf(",") + 1, inputRPM.length());

    float rpm1 = strRPM1.toFloat();
    float rpm2 = strRPM2.toFloat();

    //int voltage1 = dxl.readControlTableItem(PRESENT_VOLTAGE, DXL_ID1);
    //int temperature1 = dxl.readControlTableItem(PRESENT_TEMPERATURE, DXL_ID1);
    dxl.setGoalVelocity(DXL_ID1, rpm1);

    bool stopSign = false;
    while(!stopSign)
    {
      if(dxl.getPresentPosition(DXL_ID1, UNIT_DEGREE) >= 135)
      {
        stopSign = true;
      }

      DEBUG_SERIAL.write(dxl.readControlTableItem(PRESENT_VOLTAGE, DXL_ID1) & 0xFF);
      DEBUG_SERIAL.write(dxl.readControlTableItem(PRESENT_TEMPERATURE, DXL_ID1) & 0xFF);
      DEBUG_SERIAL.write(stopSign & 0xFF);
    }

    dxl.setGoalVelocity(DXL_ID1, 0);
  }
}