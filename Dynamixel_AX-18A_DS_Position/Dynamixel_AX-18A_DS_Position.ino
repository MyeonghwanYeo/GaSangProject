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
const uint8_t DXL_ID2 = 2;
const uint8_t DXL_ID3 = 3;
const uint8_t DXL_ID4 = 4;
const uint8_t DXL_ID5 = 5;
const float DXL_PROTOCOL_VERSION = 1.0;

int startNum = 0;
String data = "";

unsigned long pretime;

String stringTarget1;
String stringTarget2;
String stringTarget3;
String stringTarget4;
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
  dxl.ping(DXL_ID3);
  dxl.ping(DXL_ID4);
  dxl.ping(DXL_ID5);

  dxl.torqueOff(DXL_ID1);
  dxl.torqueOff(DXL_ID2);
  dxl.torqueOff(DXL_ID3);
  dxl.torqueOff(DXL_ID4);
  dxl.torqueOff(DXL_ID5);

  dxl.setOperatingMode(DXL_ID1, OP_POSITION);
  dxl.setOperatingMode(DXL_ID2, OP_POSITION);
  dxl.setOperatingMode(DXL_ID3, OP_POSITION);
  dxl.setOperatingMode(DXL_ID4, OP_POSITION);
  dxl.setOperatingMode(DXL_ID5, OP_POSITION);

  //dxl.writeControlTableItem(OPERATING_MODE, DXL_ID1, 3);
  //dxl.writeControlTableItem(OPERATING_MODE, DXL_ID2, 3);

  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID1, 50);
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID2, 50);
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID3, 50);
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID4, 50);
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID5, 50);
  
  dxl.setGoalPosition(DXL_ID1, 150, UNIT_DEGREE);
  dxl.setGoalPosition(DXL_ID2, 150, UNIT_DEGREE);
  dxl.setGoalPosition(DXL_ID3, 150, UNIT_DEGREE);
  dxl.setGoalPosition(DXL_ID4, 150, UNIT_DEGREE);
  dxl.setGoalPosition(DXL_ID5, 150, UNIT_DEGREE);

  dxl.torqueOn(DXL_ID1);
  dxl.torqueOn(DXL_ID2);
  dxl.torqueOn(DXL_ID3);
  dxl.torqueOn(DXL_ID4);
  dxl.torqueOn(DXL_ID5);

  pretime = millis();

  delay(3000);
}

void loop() 
{
  while(startNum == 0) 
  { 
    if (DEBUG_SERIAL.available() > 0)
    {
      data = DEBUG_SERIAL.readString();
    }

    if(data != "")
    {
      stringRPM1 = data.substring(0, data.indexOf(','));
      int index1 = data.indexOf(',') + 1;
      stringRPM2 = data.substring(index1, data.indexOf(',', index1));
      int index2 = data.indexOf(',', index1) + 1;
      stringRPM3 = data.substring(index2, data.indexOf(',', index2));
      int index3 = data.indexOf(',', index2) + 1;
      stringRPM4 = data.substring(index3, data.indexOf(',', index3));
      int index4 = data.indexOf(',', index3) + 1;
      stringTarget1 = data.substring(index4, data.indexOf(',', index4));
      int index5 = data.indexOf(',', index4) + 1;
      stringTarget2 = data.substring(index5, data.indexOf(',', index5));
      int index6 = data.indexOf(',', index5) + 1;
      stringTarget3 = data.substring(index6, data.indexOf(',', index6));
      int index7 = data.indexOf(',', index6) + 1;
      stringTarget4 = data.substring(index7);

      startNum = 1;
    }
  }

  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID1, stringRPM1.toInt());
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID2, stringRPM2.toInt());
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID3, stringRPM2.toInt());
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID4, stringRPM3.toInt());
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID5, stringRPM4.toInt());

  float targetAngle1 = stringTarget1.toFloat();
  float targetAngle2 = stringTarget2.toFloat();
  float targetAngle3 = stringTarget3.toFloat();
  float targetAngle4 = stringTarget4.toFloat();

  dxl.setGoalPosition(DXL_ID1, 150+targetAngle1, UNIT_DEGREE);
  dxl.setGoalPosition(DXL_ID2, 150+targetAngle2, UNIT_DEGREE);
  dxl.setGoalPosition(DXL_ID3, 150-targetAngle2, UNIT_DEGREE);
  dxl.setGoalPosition(DXL_ID4, 150+targetAngle3, UNIT_DEGREE);
  dxl.setGoalPosition(DXL_ID5, 150+targetAngle4, UNIT_DEGREE);

  int temperature1 = dxl.readControlTableItem(PRESENT_TEMPERATURE, DXL_ID1);
  int temperature2 = dxl.readControlTableItem(PRESENT_TEMPERATURE, DXL_ID2);
  int temperature3 = dxl.readControlTableItem(PRESENT_TEMPERATURE, DXL_ID3);
  int temperature4 = dxl.readControlTableItem(PRESENT_TEMPERATURE, DXL_ID4);
  int temperature5 = dxl.readControlTableItem(PRESENT_TEMPERATURE, DXL_ID5);
  int voltage1 = dxl.readControlTableItem(PRESENT_VOLTAGE, DXL_ID1);
  int voltage2 = dxl.readControlTableItem(PRESENT_VOLTAGE, DXL_ID2);
  int voltage3 = dxl.readControlTableItem(PRESENT_VOLTAGE, DXL_ID3);
  int voltage4 = dxl.readControlTableItem(PRESENT_VOLTAGE, DXL_ID4);
  int voltage5 = dxl.readControlTableItem(PRESENT_VOLTAGE, DXL_ID5);
  int load1 = dxl.readControlTableItem(PRESENT_LOAD, DXL_ID1);
  int load2 = dxl.readControlTableItem(PRESENT_LOAD, DXL_ID2);
  int load3 = dxl.readControlTableItem(PRESENT_LOAD, DXL_ID3);
  int load4 = dxl.readControlTableItem(PRESENT_LOAD, DXL_ID4);
  int load5 = dxl.readControlTableItem(PRESENT_LOAD, DXL_ID5);

  float presentAngle1 = dxl.getPresentPosition(DXL_ID1, UNIT_DEGREE);
  float presentAngle2 = dxl.getPresentPosition(DXL_ID2, UNIT_DEGREE);
  float presentAngle3 = dxl.getPresentPosition(DXL_ID3, UNIT_DEGREE);
  float presentAngle4 = dxl.getPresentPosition(DXL_ID4, UNIT_DEGREE);
  float presentAngle5 = dxl.getPresentPosition(DXL_ID5, UNIT_DEGREE);

  unsigned long nowtime = millis();

  if(nowtime - pretime >= 1000)
  {
    // DEBUG_SERIAL.println(temperature1);
    DEBUG_SERIAL.println(temperature2);
    DEBUG_SERIAL.println(temperature3);
    // DEBUG_SERIAL.println(temperature4);
    // DEBUG_SERIAL.println(temperature5);

    // DEBUG_SERIAL.println(voltage1);
    DEBUG_SERIAL.println(voltage2);
    DEBUG_SERIAL.println(voltage3);
    // DEBUG_SERIAL.println(voltage4);
    // DEBUG_SERIAL.println(voltage5);

    // DEBUG_SERIAL.println(load1);
    DEBUG_SERIAL.println(load2);
    DEBUG_SERIAL.println(load3);
    // DEBUG_SERIAL.println(load4);
    // DEBUG_SERIAL.println(load5);

    pretime = nowtime;
  }
}