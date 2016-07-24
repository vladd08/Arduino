
#include <SPI.h>
#include <Ethernet.h>

byte mac[] = {0x90, 0xA2, 0xDA, 0x0D, 0x48, 0xD3 };

IPAddress ip(10,10,2,94);
IPAddress gateway(10,10,0,254);
IPAddress subnet(255,255,0,0);

EthernetServer server(80);
String readString;
int led = 8;

void setup()
{
pinMode(led, OUTPUT); 

  Serial.begin(9600);

  Ethernet.begin(mac, ip, gateway, subnet);
  server.begin();
  Serial.print("Server is at ");
  Serial.println(Ethernet.localIP());
}

void loop()
{
  EthernetClient client = server.available();

  if(client)
  {
    Serial.println("New client");

    while(client.connected())
    {
      if(client.available())
      {
        char c=client.read();
        Serial.println(c);

        switch(c)
        {
          case 'A':
          digitalWrite(led,HIGH);
          Serial.println("Led on");
          break;
          case 'B':
          digitalWrite(led,LOW);
          Serial.println("Led off");
          break;
        }

        c=' ';

        delay(1);
        client.stop();
      }
    }  
  }
}

 
