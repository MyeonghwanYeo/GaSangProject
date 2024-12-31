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

const uint8_t DXL_ID1 = 1;
const uint8_t DXL_ID2 = 3;
const float DXL_PROTOCOL_VERSION = 1.0;

// float targetAngle1 = 0;
// float targetAngle2 = 0;
// int startNum = 0;

DynamixelShield dxl;

using namespace ControlTableItem;

void setup() 
{
  DEBUG_SERIAL.begin(115200);
  
  dxl.begin(1000000);
  dxl.setPortProtocolVersion(DXL_PROTOCOL_VERSION);

  dxl.ping(DXL_ID1);
  dxl.ping(DXL_ID2);

  dxl.torqueOff(DXL_ID1);
  dxl.torqueOff(DXL_ID2);

  dxl.setOperatingMode(DXL_ID1, OP_POSITION);
  dxl.setOperatingMode(DXL_ID2, OP_POSITION);

  //dxl.writeControlTableItem(OPERATING_MODE, DXL_ID1, 3);
  //dxl.writeControlTableItem(OPERATING_MODE, DXL_ID2, 3);

  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID1, 100);
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID2, 100);

  dxl.setGoalPosition(DXL_ID1, 60, UNIT_DEGREE);
  dxl.setGoalPosition(DXL_ID2, 240, UNIT_DEGREE);

  delay(3000);

  dxl.torqueOn(DXL_ID1);
  dxl.torqueOn(DXL_ID2);
}

void loop() 
{
  int temperature1 = dxl.readControlTableItem(PRESENT_TEMPERATURE, DXL_ID1);
  int temperature2 = dxl.readControlTableItem(PRESENT_TEMPERATURE, DXL_ID2);
  int voltage1 = dxl.readControlTableItem(PRESENT_VOLTAGE, DXL_ID1);
  int voltage2 = dxl.readControlTableItem(PRESENT_VOLTAGE, DXL_ID2);
  int load1 = dxl.readControlTableItem(PRESENT_LOAD, DXL_ID1);
  int load2 = dxl.readControlTableItem(PRESENT_LOAD, DXL_ID2);

  float presentAngle1 = dxl.getPresentPosition(DXL_ID1, UNIT_DEGREE);
  float presentAngle2 = dxl.getPresentPosition(DXL_ID2, UNIT_DEGREE);

  float targetAngle1 = presentAngle1 + 4.0f;
  float targetAngle2 = presentAngle2 - 4.0f;

  dxl.setGoalPosition(DXL_ID1, targetAngle1, UNIT_DEGREE);
  dxl.setGoalPosition(DXL_ID2, targetAngle2, UNIT_DEGREE);

  DEBUG_SERIAL.write(temperature1 & 0xFF);
  //DEBUG_SERIAL.write(temperature2 & 0xFF);
  DEBUG_SERIAL.write(voltage1 & 0xFF);
  //DEBUG_SERIAL.write(voltage2 & 0xFF);
  DEBUG_SERIAL.write(load1 & 0xFF);
  //DEBUG_SERIAL.write(load2 & 0xFF);
  //DEBUG_SERIAL.write(temperature1 & 0xFF);

  delay(10);
  //String inputRPM = DEBUG_SERIAL.readString();
}