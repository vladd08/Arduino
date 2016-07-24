void setup()
{
  pinMode(8,OUTPUT); //Led VERDE
  pinMode(9,OUTPUT); // Led ALBASTRU
  pinMode(10,OUTPUT); //Led ROSU
  pinMode(11,OUTPUT); //Difuzor
  Serial.begin(9600);
}

void loop()
{

  int Water = analogRead(0);
  Serial.println(Water);
  delay(10);

  if(Water >= 540 && Water <= 570)
  {
  digitalWrite(8,HIGH);
  digitalWrite(10,LOW);
  digitalWrite(9,LOW);
  noTone(11);
  }
  else if (Water >= 500 &&  Water <= 540)
  {
  digitalWrite(8,LOW); 
  digitalWrite(10,HIGH);
  digitalWrite(9,LOW);
  noTone(11);
  }
  else if (Water <500 || Water >570)
  {
  digitalWrite(8,LOW); 
  digitalWrite(10,LOW);
  digitalWrite(9,HIGH);
  for(int i=1500;i<1800;i++)
  tone(11,i);
  }
  
  

  
}

