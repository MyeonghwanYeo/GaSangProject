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

  dxl.torqueOn(DXL_ID1);
}

void loop() 
{
  int temperature1 = dxl.readControlTableItem(PRESENT_TEMPERATURE, DXL_ID1);
  int voltage1 = dxl.readControlTableItem(PRESENT_VOLTAGE, DXL_ID1);

  float presentAngle = dxl.getPresentPosition(DXL_ID1, UNIT_DEGREE);
  float targetAngle = presentAngle + 2.0f;

  dxl.setGoalPosition(DXL_ID1, targetAngle, UNIT_DEGREE);

  DEBUG_SERIAL.write(temperature1 & 0xFF);
  DEBUG_SERIAL.write(voltage1 & 0xFF);
  //DEBUG_SERIAL.write(temperature1 & 0xFF);

  delay(1);
  //String inputRPM = DEBUG_SERIAL.readString();
}