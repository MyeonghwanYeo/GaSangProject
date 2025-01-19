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

const uint8_t DXL_ID_Arr[5] = {6, 2, 3, 4, 5};
const float DXL_PROTOCOL_VERSION = 1.0;

int startNum = 0;
String data = "";

unsigned long pretime;

String stringRPM[4];
String stringTarget[4];
float targetAngle_arr[5];

int angleID6 = 512;
int angleID2 = 512;
int angleID3 = 512;
int angleID4 = 512;
int angleID5 = 512;

String presnetAngle;

DynamixelShield dxl;

using namespace ControlTableItem;

void setup() 
{
  DEBUG_SERIAL.begin(115200);

  pinMode(4, INPUT_PULLUP);
  pinMode(13, INPUT_PULLUP);

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

  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID_Arr[0], 100);
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID_Arr[1], 100);
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID_Arr[2], 100);
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID_Arr[3], 200);
  dxl.writeControlTableItem(MOVING_SPEED, DXL_ID_Arr[4], 200);

  pretime = millis();

  delay(100);
}

void loop()
{
  if(DEBUG_SERIAL.available() > 2)
  {
    String modeStr = DEBUG_SERIAL.readString();

    delay(100);

    if(modeStr == "Read")
    {
      // 6번 모터 제어
      if(analogRead(A0) > 1000)
      {
        dxl.setGoalPosition(DXL_ID_Arr[0], angleID6+5);

        delay(100);

        angleID6 = dxl.readControlTableItem(PRESENT_POSITION, DXL_ID_Arr[0]);
      }
      else if (analogRead(A0) < 25)
      {
        dxl.setGoalPosition(DXL_ID_Arr[0], angleID6-5);

        delay(100);

        angleID6 = dxl.readControlTableItem(PRESENT_POSITION, DXL_ID_Arr[0]);
      }

      // 2번, 3번 모터 제어
      if(analogRead(A1) > 1000)
      {
        dxl.setGoalPosition(DXL_ID_Arr[1], angleID2+5);
        dxl.setGoalPosition(DXL_ID_Arr[2], angleID3-5);

        delay(100);

        angleID2 = dxl.readControlTableItem(PRESENT_POSITION, DXL_ID_Arr[1]);
        angleID3 = dxl.readControlTableItem(PRESENT_POSITION, DXL_ID_Arr[2]);
      }
      else if (analogRead(A1) < 25)
      {
        dxl.setGoalPosition(DXL_ID_Arr[1], angleID2-5);
        dxl.setGoalPosition(DXL_ID_Arr[2], angleID3+5);

        delay(100);

        angleID2 = dxl.readControlTableItem(PRESENT_POSITION, DXL_ID_Arr[1]);
        angleID3 = dxl.readControlTableItem(PRESENT_POSITION, DXL_ID_Arr[2]);
      }

      // 4번 모터 제어
      if(analogRead(A2) > 1000)
      {
        dxl.setGoalPosition(DXL_ID_Arr[3], angleID4+5);

        delay(100);

        angleID4 = dxl.readControlTableItem(PRESENT_POSITION, DXL_ID_Arr[3]);
      }
      else if (analogRead(A2) < 25)
      {
        dxl.setGoalPosition(DXL_ID_Arr[3], angleID4-5);

        delay(100);

        angleID4 = dxl.readControlTableItem(PRESENT_POSITION, DXL_ID_Arr[3]);
      }

      // 5번 모터 제어
      if(analogRead(A3) > 1000)
      {
        dxl.setGoalPosition(DXL_ID_Arr[4], angleID5+5);

        delay(100);

        angleID5 = dxl.readControlTableItem(PRESENT_POSITION, DXL_ID_Arr[4]);
      }
      else if (analogRead(A3) < 25)
      {
        dxl.setGoalPosition(DXL_ID_Arr[4], angleID5-5);

        delay(100);

        angleID5 = dxl.readControlTableItem(PRESENT_POSITION, DXL_ID_Arr[4]);
      }

      presnetAngle = String(angleID6) + ',' + String(angleID2) + ',' + String(angleID4) + ',' + String(angleID5)) + ',';
    }

    else if(modeStr == "Off")
    {
      for(int i = 0; i < 5; i++)
      {
        dxl.setGoalPosition(DXL_ID_Arr[i], 150, UNIT_DEGREE);
      }

      delay(3000);
    }

    else if(modeStr != "Read" && modeStr != "Off")
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

      presnetAngle = "";
    }

    int tempArr[5];
    int voltArr[5];
    int loadArr[5];

    if(modeStr != "Off")
    {
      for(int i = 0; i < 5; i++)
      {
        dxl.setGoalPosition(DXL_ID_Arr[i], targetAngle_arr[i], UNIT_DEGREE);

        tempArr[i] = dxl.readControlTableItem(PRESENT_TEMPERATURE, DXL_ID_Arr[i]);
        voltArr[i] = dxl.readControlTableItem(PRESENT_VOLTAGE, DXL_ID_Arr[i]);
        loadArr[i] = dxl.readControlTableItem(PRESENT_LOAD, DXL_ID_Arr[i]);
      }
    }

    String sendData = presnetAngle + String(tempArr[0]) + ',' + String(voltArr[0]) + ',' + String(loadArr[0])
    + ',' + String(tempArr[1]) + ',' + String(voltArr[1]) + ',' + String(loadArr[1])
    + ',' + String(tempArr[2]) + ',' + String(voltArr[2]) + ',' + String(loadArr[2])
    + ',' + String(tempArr[3]) + ',' + String(voltArr[3]) + ',' + String(loadArr[3])
    + ',' + String(tempArr[4]) + ',' + String(voltArr[4]) + ',' + String(loadArr[4])

    DEBUG_SERIAL.println(sendData);

    delay(100);
  }
} 