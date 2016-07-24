#include <Wire.h>
#include <Adafruit_Sensor.h>
#include <Adafruit_HMC5883_U.h>
#include<LiquidCrystal.h>
#include<SD.h>

LiquidCrystal lcd(9,8,4,5,6,7);

Adafruit_HMC5883_Unified mag = Adafruit_HMC5883_Unified(12345);

void setup(void) 
{
  Serial.begin(9600);
  
  if(!mag.begin())
  {
    Serial.println("Ooops, no HMC5883 detected ... Check your wiring!");
    while(1);
  }
  lcd.begin(16,2);
  pinMode(10,OUTPUT);

   if (!SD.begin(10))
   {
    Serial.println("initialization failed!");
    return;
   }
    Serial.println("initialization done.");
}

void loop(void) 
{
  
  sensors_event_t event; 
  mag.getEvent(&event);
 
  Serial.print("X: "); Serial.print(event.magnetic.x); Serial.print("  ");
  Serial.print("Y: "); Serial.print(event.magnetic.y); Serial.print("  ");
  Serial.print("Z: "); Serial.print(event.magnetic.z); Serial.print("  ");Serial.println("uT");

  float heading = atan2(event.magnetic.y, event.magnetic.x);
  
  float declinationAngle = 0.22;
  heading += declinationAngle;
  
  if(heading < 0)
    heading += 2*PI;
    
  if(heading > 2*PI)
    heading -= 2*PI;
    
  float head = heading * 180/M_PI; 
  
  Serial.print("Heading (degrees): "); Serial.println(head);
  
  delay(500);

  lcd.setCursor(0,0);
  lcd.print("Heading:");
  lcd.print(head,2);
  lcd.print("   ");

  if(head>=0 && head<1)
  {
    lcd.setCursor(0,1);
    lcd.print("North             ");
  }

  if(head>=1 && head<89)
  {
    lcd.setCursor(0,1);
    lcd.print("North-West          ");
  }
  
  if(head>=89 && head<90)
  {
    lcd.setCursor(0,1);
    lcd.print("West                ");
  }

  if(head>=90 && head<179)
  {
    lcd.setCursor(0,1);
    lcd.print("South-West           ");
  }

  if(head>=179 && head<180)
  {
    lcd.setCursor(0,1);
    lcd.print("South             ");
  }

  if(head>=180 && head<269)
  {
    lcd.setCursor(0,1);
    lcd.print("South-East        ");
  }

  if(head>=269 && head<270)
  {
    lcd.setCursor(0,1);
    lcd.print("East              ");
  }

  if(head>=270 && head<359)
  {
    lcd.setCursor(0,1);
    lcd.print("North-East       ");
  }

  if(head>=359 && head<360)
  {
    lcd.setCursor(0,1);
    lcd.print("North            ");
  }

  delay(500);
}

