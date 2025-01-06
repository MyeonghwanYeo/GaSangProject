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

const uint8_t DXL_ID1 = 6;
const uint8_t DXL_ID2 = 3;
const float DXL_PROTOCOL_VERSION = 1.0;

int startNum = 0;

unsigned long pretime;

String stringTarget;
String stringRPM1;
String stringRPM2;
String stringRPM3;
String stringRPM4;

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

  dxl.setGoalPosition(DXL_ID1, 150, UNIT_DEGREE);
  dxl.setGoalPosition(DXL_ID2, 150, UNIT_DEGREE);

  dxl.torqueOn(DXL_ID1);
  dxl.torqueOn(DXL_ID2);

  float presentAngle = dxl.getPresentPosition(DXL_ID1, UNIT_DEGREE);

  DEBUG_SERIAL.println(presentAngle);

  pretime = millis();
}

void loop() 
{
  // if(DEBUG_SERIAL.available() > 0 && startNum == 0)
  // {
  //   stringTarget = DEBUG_SERIAL.readString();
  //   stringRPM1 = DEBUG_SERIAL.readString();
  //   stringRPM2 = DEBUG_SERIAL.readString();
  //   stringRPM3 = DEBUG_SERIAL.readString();
  //   stringRPM4 = DEBUG_SERIAL.readString();

  //   startNum = 1;
  // }

  // dxl.writeControlTableItem(MOVING_SPEED, DXL_ID1, stringRPM1.toInt()*114/1024);
  // dxl.writeControlTableItem(MOVING_SPEED, DXL_ID2, stringRPM2.toInt()*114/1024);
  
  // int temperature1 = dxl.readControlTableItem(PRESENT_TEMPERATURE, DXL_ID1);
  // int temperature2 = dxl.readControlTableItem(PRESENT_TEMPERATURE, DXL_ID2);
  // int voltage1 = dxl.readControlTableItem(PRESENT_VOLTAGE, DXL_ID1);
  // int voltage2 = dxl.readControlTableItem(PRESENT_VOLTAGE, DXL_ID2);
  // int load1 = dxl.readControlTableItem(PRESENT_LOAD, DXL_ID1);
  // int load2 = dxl.readControlTableItem(PRESENT_LOAD, DXL_ID2);

  // float presentAngle1 = dxl.getPresentPosition(DXL_ID1, UNIT_DEGREE);
  // float presentAngle2 = dxl.getPresentPosition(DXL_ID2, UNIT_DEGREE);

  // float targetAngle1 = stringTarget.toFloat();
  // float targetAngle2 = stringTarget.toFloat();

  // dxl.setGoalPosition(DXL_ID1, targetAngle1, UNIT_DEGREE);
  // dxl.setGoalPosition(DXL_ID2, targetAngle2, UNIT_DEGREE);

  // unsigned long nowtime = millis();

  // if(nowtime - pretime >= 1000)
  // {
  //   DEBUG_SERIAL.println(temperature1);
  //   //DEBUG_SERIAL.write(temperature2 & 0xFF);
  //   DEBUG_SERIAL.println(voltage1);
  //   //DEBUG_SERIAL.write(voltage2 & 0xFF);
  //   DEBUG_SERIAL.println(load1);
  //   //DEBUG_SERIAL.write(load2 & 0xFF);

  //   pretime = nowtime;
  // }
}