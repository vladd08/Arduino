int buttonPin = 2;
int yellowLed = 3;
int redLed = 4;
int greenLed = 5;
int currentLed = 0; 


void setup() {
  pinMode(buttonPin, INPUT);      
  pinMode(yellowLed, OUTPUT);   
  pinMode(redLed, OUTPUT);   
  pinMode(greenLed, OUTPUT); 
  Serial.begin(9600);
}

void loop()
{

  int  button=digitalRead(buttonPin);

  if(button)
  {
    switch(currentLed)
    {
      case 0:
      digitalWrite(yellowLed,HIGH);
      digitalWrite(redLed,LOW);
      digitalWrite(greenLed,LOW);
      currentLed=currentLed+1;
      delay(250);
      break;

      case 1:
      digitalWrite(redLed,HIGH);
      digitalWrite(yellowLed,LOW);
      digitalWrite(greenLed,LOW);
      currentLed=currentLed+1;
      delay(250);
      break;

      case 2:
      digitalWrite(greenLed,HIGH);
      digitalWrite(redLed,LOW);
      digitalWrite(yellowLed,LOW);
      currentLed=0;
      delay(250);
      break;}
      }
}
