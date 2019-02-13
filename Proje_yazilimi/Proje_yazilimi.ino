#include <EEPROM.h>
#include <Servo.h>
unsigned long old_time;
int buzzerRole = 2;
int ikazRole = 4;
int fanRole = 7;
int yanginPompRole = 8;
int tahliyePompRole = 10;
int servoPin = 9;
int siviTolerans = 500;
bool resetmi = false;


int yanginyok = 0;
int yanginvar1 = 1;
int fanrun = 2;
int fanstop = 3;
int pomprun = 4;
int pompstop = 5;
int timer = 6;
int yanginvar2 = 7;
int reset = 8;
Servo servo;
void portBagla()
{
  Serial.begin(9600);
}

void roleleriBagla()
{
  pinMode(buzzerRole, OUTPUT);
  pinMode(ikazRole, OUTPUT);
  pinMode(fanRole, OUTPUT);
  pinMode(tahliyePompRole, OUTPUT);
  pinMode(yanginPompRole, OUTPUT);
}
void yanginSensoruKur()
{
  
}
void siviSensoruKur()
{
  
}
bool dumanVarmi1()
{
  return (analogRead(A0) > 300);
}
bool dumanVarmi2()
{
  return (analogRead(A3) > 300);
}
void buzzerRun()
{
  digitalWrite(buzzerRole, HIGH);
}
void stopBuzzer()
{
  digitalWrite(buzzerRole, LOW);
}
void ikazRun()
{
  digitalWrite(ikazRole, HIGH);
}
void stopIkaz()
{
  digitalWrite(ikazRole, LOW);
}
void fanRun()
{
  digitalWrite(fanRole, HIGH);
  Serial.println(fanrun);
  delay(250);
}
void stopFan()
{
  digitalWrite(fanRole, LOW);
  Serial.println(fanstop);
  delay(250);
}
void yanginPompRun()
{
  digitalWrite(yanginPompRole, HIGH);
  Serial.println(pomprun);
  delay(250);
}
void stopYanginPomp()
{
  digitalWrite(yanginPompRole, LOW);
  Serial.println(pompstop);
  delay(250);
}
void tahliyePompRun()
{
  digitalWrite(tahliyePompRole, HIGH);
}
void stopTahliyePomp()
{
  digitalWrite(tahliyePompRole, LOW);
}
void servoBagla()
{
  servo.attach(servoPin);
}
void damperAc()
{
  servo.write(90);
}
void damperKapat()
{
  servo.write(45);
}
bool iptalEdildiMi()
{
  if (Serial.available() > 0) 
  {
    Serial.readString();
    return true;
  }
  return false;
}
bool resetlendiMi()
{
  if (Serial.available() > 0) 
  {
    Serial.readString();
    return true;
  }
  return false;
}
void damperveFanAc()
{
  damperAc();
  fanRun();
}
void damperveFanKapat()
{
  damperKapat();
  stopFan();
}
unsigned long timerStart()
{
  Serial.println(timer);
  return millis();
}
void bekle()
{
  old_time = timerStart();
  delay(250);
  while((millis() - old_time) < 30000)
  {
      //Serial.println((millis() - old_time)/1000);
      if(iptalEdildiMi())
      {
        sifirla();
        return;
      }
  }
}
void arayuzReset()
{
  Serial.println(reset);
  delay(250);
}
void sifirla()
{
  stopBuzzer(); //ok
  stopIkaz();   //ok
  damperveFanAc(); //ok
  arayuzReset(); //ok
  resetmi = true;
}
bool yanginSensoruCheck()
{
  return true;
}
bool siviSensoruCheck()
{
  return true;
}
void basla()
{
  portBagla(); //ok

  yanginSensoruKur();
  while(!yanginSensoruCheck())
  {
    yanginSensoruKur();
  }
  
  siviSensoruKur();
  while(!siviSensoruCheck())
  {
    siviSensoruKur();
  }

  servoBagla(); //ok
  
  roleleriBagla(); //ok
}

void yaniyosun1()
{
  Serial.println(yanginvar1);
  delay(250);
}
void yaniyosun2()
{
  Serial.println(yanginvar2);
  delay(250);
}
void setup() 
{
  basla();
}
bool siviSeviyesiAz()
{
  if(analogRead(A1) < 630)  return true;
  return false;
}
bool siviSeviyesiCok()
{
  if(analogRead(A1) > siviTolerans)  return true;
  return false;
}
void loop() 
{
  bool yangin = false;
  if(dumanVarmi1())
  {
    yangin = true;
    yaniyosun1(); //ok
    resetmi = false;
  }
//  if(dumanVarmi2())
//  {
//    yangin = true;
//    yaniyosun2(); //ok
//    resetmi = false;
//  }
  if(yangin)
  {
    buzzerRun(); //ok
    ikazRun(); //ok
    damperveFanKapat();// icinde arayuz baglantisi olacak
    bekle(); //ok
    yanginPompRun(); // icinde arayuz baglantisi olacak
    stopBuzzer(); //ok
    while(!resetmi)
    {
      //Serial.println(analogRead(A1));
      resetmi = resetlendiMi();
      if(!siviSeviyesiAz())
      {
        //suan yangin pompasi calisiyor
        buzzerRun(); //ok
        stopYanginPomp(); //ok
        tahliyePompRun(); //ok
        break;
      }
      delay(250);
    }
    
    while(!resetmi)
    {
      //Serial.println(analogRead(A1));
      resetmi = resetlendiMi();
      if(!siviSeviyesiCok())
      {
        stopTahliyePomp(); //ok
        stopBuzzer(); //ok
        break;
      }
      delay(250);
    }
    while(!resetmi)
    {
      resetmi = resetlendiMi();
    }
    sifirla();
  }
  else
  {
    Serial.println(yanginyok);
  }

  delay(500);
}
