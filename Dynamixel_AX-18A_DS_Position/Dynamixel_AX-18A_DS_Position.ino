#include <DynamixelShield.h>
#include <avr/wdt.h>

#if defined(ARDUINO_AVR_UNO) || defined(ARDUINO_AVR_MEGA2560)
  #include <SoftwareSerial.h>

  SoftwareSerial soft_serial(7, 8);
  #define DEBUG_SERIAL soft_serial

#elif defined(ARDUINO_SAM_DUE) || defined(ARDUINO_SAM_ZERO)
  #define DEBUG_SERIAL SerialUSB

#else
  #define DEBUG_SERIAL Serial

#endif

const uint8_t DXL_ID_Arr[5] = {6, 2, 3, 4, 5};
const float DXL_PROTOCOL_VERSION = 1.0;

int startNum = 0;
String data = "";

unsigned long pretime;

String stringRPM[4];
String stringTarget[4];
float targetAngle_arr[5];

DynamixelShield dxl;

using namespace ControlTableItem;

void setup() 
{
  DEBUG_SERIAL.begin(115200);

  dxl.begin(1000000);
  dxl.setPortProtocolVersion(DXL_PROTOCOL_VERSION);

  for(int i = 0; i < 5; i++)
  {
    dxl.ping(DXL_ID_Arr[i]);

    dxl.torqueOff(DXL_ID_Arr[i]);

    dxl.setOperatingMode(DXL_ID_Arr[i], OP_POSITION);

    dxl.setGoalPosition(DXL_ID_Arr[i], 150, UNIT_DEGREE);

    dxl.torqueOn(DXL_ID_Arr[i]);
  }

  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID_Arr[0], 50);
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID_Arr[1], 50);
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID_Arr[2], 50);
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID_Arr[3], 150);
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID_Arr[4], 250);

  pretime = millis();

  delay(100);
}

void loop() 
{
  while(startNum == 0)
  {
    if(DEBUG_SERIAL.available() > 0)
    {
      data = DEBUG_SERIAL.readString();
      
      delay(100);
      stringTarget[0] = data.substring(0, data.indexOf(','));
      int index1 = data.indexOf(',') + 1;
      stringTarget[1] = data.substring(index1, data.indexOf(',', index1));
      int index2 = data.indexOf(',', index1) + 1;
      stringTarget[2] = data.substring(index2, data.indexOf(',', index2));
      int index3 = data.indexOf(',', index2) + 1;
      stringTarget[3] = data.substring(index3);

      targetAngle_arr[0] = 150+stringTarget[0].toFloat();
      targetAngle_arr[1] = 150+stringTarget[1].toFloat();
      targetAngle_arr[2] = 150-stringTarget[1].toFloat();
      targetAngle_arr[3] = 150-stringTarget[2].toFloat();
      targetAngle_arr[4] = 150+stringTarget[3].toFloat();

      startNum = 1;
    }
  }
  
  int temperature_arr[5];
  int voltage_arr[5];
  int load_arr[5];

  for(int i = 0; i < 5; i++)
  {
    dxl.setGoalPosition(DXL_ID_Arr[i], targetAngle_arr[i], UNIT_DEGREE);

    temperature_arr[i] = dxl.readControlTableItem(PRESENT_TEMPERATURE, DXL_ID_Arr[i]);
    voltage_arr[i] = dxl.readControlTableItem(PRESENT_VOLTAGE, DXL_ID_Arr[i]);
    load_arr[i] = dxl.readControlTableItem(PRESENT_LOAD, DXL_ID_Arr[i]);
  }

  unsigned long nowtime = millis();

  if(nowtime - pretime >= 1000)
  {

    DEBUG_SERIAL.println(temperature_arr[0]);
    DEBUG_SERIAL.println(voltage_arr[0]);
    DEBUG_SERIAL.println(load_arr[0]);

    DEBUG_SERIAL.println(temperature_arr[1]);
    DEBUG_SERIAL.println(voltage_arr[1]);
    DEBUG_SERIAL.println(load_arr[1]);

    DEBUG_SERIAL.println(temperature_arr[2]);
    DEBUG_SERIAL.println(voltage_arr[2]);
    DEBUG_SERIAL.println(load_arr[2]);

    DEBUG_SERIAL.println(temperature_arr[3]);
    DEBUG_SERIAL.println(voltage_arr[3]);
    DEBUG_SERIAL.println(load_arr[3]);

    DEBUG_SERIAL.println(temperature_arr[4]);
    DEBUG_SERIAL.println(voltage_arr[4]);
    DEBUG_SERIAL.println(load_arr[4]);
    delay(10);

    pretime = nowtime;
  }

  if (DEBUG_SERIAL.available() > 0)
  {
    startNum = 0;

    wdt_enable(WDTO_15MS);
    while(1) 
    {}
  }
}