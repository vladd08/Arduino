void setup()
{
  //seteaza pin 1 , 6 ca si output  
  DDRD = B01000100;
  setTimer0();
  setTimer1();
  setTimer2();
}

int op = 0;
int duty = 1;

void loop()
{
  
}

void setTimer1()
{
   cli();          
   TCCR1A = 0;     
   TCCR1B = 0;  

   //intrerupere la 1 secunda 
   OCR1A = 9999;

   //seteaza mod CTC
   TCCR1B |= (1 << WGM12);
   
   //seteaza prescaler la 1024
   TCCR1B |= (1 << CS10);    
   TCCR1B |= (1 << CS12);

   //activeaza ISR
   TIMSK1 |= (1 << OCIE1A);
   sei();
}
ISR(TIMER1_COMPA_vect)
{
   // La fiecare intrerupere, aprinde led-ul
   // De pe pinul 1
   PIND=B00000100;
}

void setTimer0() //genereaza PWM
{
  //seteaza mod non-inverted
  TCCR0A |= (1 << COM0A1);
  //seteaza fast PWM cu TOP la 0xFF
  TCCR0A |= (1 << WGM01) | (1 << WGM00);
  //seteaza no prescaler
  TCCR0B |= (1 << CS00);
}

void setTimer2()
{
   cli();          
   TCCR2A = 0;     
   TCCR2B = 0;  

   //seteaza mod CTC
   TCCR2A |= (1 << WGM21);
   OCR2A=74; //intrerupere la 5ms
   //seteaza prescalera la 1024
   TCCR2B |= (1<<CS22) | (1 << CS21) | (1<<CS20);
   //activeaza intreruperi
   TIMSK2 |= (1 << OCIE2A);
   sei();
}
ISR(TIMER2_COMPA_vect)
{
   //incrementarea duty simuleaza timpul
   //duty=200 incrementat cu timer de 5 ms
   //inseamna 1 secunda / incrementare

   //creste luminozitatea timp de o secunda
   if(duty > 0 && duty < 200 && op == 0)
   {
     duty++;
     OCR0A = duty;
   }
   //ramane pe luminozitate maxima timp de inca o secunda
   else if(duty >= 200 && op == 0)
   {
     duty++;
     OCR0A = 200;
     if (duty == 400)
     {
       duty=200;
       op=1;
     }
   }
   //scade luminozitatea la 0 intr-o secunda
   else if(duty > 0 && duty<=200 && op == 1)
   {
     duty--;
     OCR0A = duty;
   }
   //ramane pe luminozitate 0 timp de o secunda si repeta
   else if(duty <= 0 && op == 1)
   {
     duty--;
     {
       if(duty==-200)
       {
         op=0;
         duty=1;
       }
     }
   }
}


