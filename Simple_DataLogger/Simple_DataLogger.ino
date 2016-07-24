#include<SPI.h>
#include<SD.h>

const int chipSelect = 4;

void setup() {
Serial.begin(9600);

while(!Serial)
{
  ;
}

 Serial.print("Initializing SD card...");

 if(!SD.begin(chipSelect))
 {
  Serial.println("Card failed, or not present");
  return;
 }

 Serial.println("Card initialized.");

}

void loop() {
  String dataString="";

  for(int analogPin = 0; analogPin<3;analogPin++)
  {
    int sensor = analogRead(analogPin);
    dataString +=String(sensor);
    if(analogPin <2)
    {
      dataString+=",";
    }
  }

  File dataFile=SD.open("datalog.txt", FILE_WRITE);

  if(dataFile)
  {
    dataFile.println(dataString);
    dataFile.close();
    Serial.println(dataString);
  }

  else
  Serial.println("Error opening datalog.txt");
}
