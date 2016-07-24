#include <Adafruit_GPS.h> 
#include <SoftwareSerial.h> 
SoftwareSerial mySerial(10,11); 
Adafruit_GPS GPS(&mySerial); 
 
String NMEA1;  
String NMEA2;  
char c;       
 
void setup()  
{
  Serial.begin(115200);  
  GPS.begin(9600);       
  GPS.sendCommand("$PGCMD,33,0*6D"); 
  GPS.sendCommand(PMTK_SET_NMEA_OUTPUT_RMCGGA); 
  GPS.sendCommand(PMTK_SET_NMEA_UPDATE_1HZ);   
  delay(1000);  
}
 
 
void loop()                     
{
readGPS();  
 
}

void readGPS(){  
  clearGPS();    
  while(!GPS.newNMEAreceived()) { 
  c=GPS.read(); 
  }
GPS.parse(GPS.lastNMEA());  
NMEA1=GPS.lastNMEA();      
while(!GPS.newNMEAreceived()) {  
  c=GPS.read();
  }
GPS.parse(GPS.lastNMEA());
NMEA2=GPS.lastNMEA();
  Serial.println(NMEA1);
  Serial.println(NMEA2);
  Serial.println("");
}
void clearGPS() {  
while(!GPS.newNMEAreceived()) {
  c=GPS.read();
  }
GPS.parse(GPS.lastNMEA());
while(!GPS.newNMEAreceived()) {
  c=GPS.read();
  }
GPS.parse(GPS.lastNMEA());
 
}
                          
