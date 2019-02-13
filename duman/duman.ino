int buzzer = 9;
int led = 8;
int esikdegeri=400;
int deger;
int analog_giris=A0;
int led_green=10;
/*
void startduman_Dedektoru()
{
  
}


void stopduman_Dedektoru()
{
  
}
*/

void start_buzzer()
{
  tone(buzzer,1000);
  digitalWrite(9, HIGH);
  
}

void stop_buzzer()
{
  noTone(buzzer);
  digitalWrite(9, LOW);
}


void start_led()
{
  digitalWrite(8, HIGH);
  
}

void stop_led()
{
  digitalWrite(8, LOW);
  
}

void normal_durum()
{
  digitalWrite(led_green, HIGH);
}
void duman_var()
{
  digitalWrite(led_green, LOW);
}


void setup()
{
  
  pinMode(buzzer, OUTPUT);
  pinMode(led, OUTPUT);
  
  
}

void loop()
{
  deger=analogRead(analog_giris);
 if(deger>esikdegeri)
 {
    duman_var();
    start_buzzer();
    start_led();
    delay(100);
    stop_led();
    delay(100);
      
 }
else
{
  normal_durum();
  stop_buzzer();
  stop_led();

}
 
}
