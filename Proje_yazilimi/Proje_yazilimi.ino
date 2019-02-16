#include <EEPROM.h>
#include <Servo.h>
#define dly delay(150)
unsigned long old_time;
int buzzerRole = 2;
int ikazRole = 8;
int fanRole = 7;
int yanginPompRole = 4;
int tahliyePompRole = 10;
int servoPin = 9;
int siviTolerans = 500;
int siviMax = 590;
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
int tahliyerun = 9;
int tahliyestop = 10;
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
  dly;
}
void stopFan()
{
  digitalWrite(fanRole, LOW);
  Serial.println(fanstop);
  dly;
}
void yanginPompRun()
{
  digitalWrite(yanginPompRole, HIGH);
  Serial.println(pomprun);
  dly;
}
void stopYanginPomp()
{
  digitalWrite(yanginPompRole, LOW);
  Serial.println(pompstop);
  dly;
}
void tahliyePompRun()
{
  digitalWrite(tahliyePompRole, HIGH);
  Serial.println(tahliyerun);
  dly;
}
void stopTahliyePomp()
{
  digitalWrite(tahliyePompRole, LOW);
  Serial.println(tahliyestop);
  dly;
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
  servo.write(60);
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
void sifirla()
{
  stopBuzzer(); //ok
  stopIkaz();   //ok
  stopYanginPomp();
  damperveFanAc(); //ok
  arayuzReset(); //ok
  resetmi = true;
}
void bekle()
{
  old_time = timerStart();
  dly;
  while((millis() - old_time) < 15000)
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
  dly;
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
  dly;
}
void yaniyosun2()
{
  Serial.println(yanginvar2);
  dly;
}
void setup() 
{
  basla();
}
bool siviSeviyesiAz()
{
  if(analogRead(A1) < siviMax)  return true;
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
  resetmi = true;
  if(dumanVarmi1())
  {
    yangin = true;
    yaniyosun1(); //ok
    resetmi = false;
  }
//  else if(dumanVarmi2())
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
      dly;
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
      dly;
    }
    while(!resetmi)
    {
      resetmi = resetlendiMi();
    }
    sifirla();
  }
//  else
//  {
//    Serial.println(yanginyok);
//  }
  else if(Serial.available() > 0) //elle pomprun
  {
    Serial.readString();
    yanginPompRun();
    resetmi = false;
    while(Serial.available() <= 0 && siviSeviyesiAz())
    {

    }
    if(Serial.available() > 0)
    {
      Serial.readString();
      resetmi = true;
    }
    stopYanginPomp();
    if(!siviSeviyesiAz()) tahliyePompRun();
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
      dly;
    }
    while(!resetmi)
    {
      resetmi = resetlendiMi();
    }
    sifirla();
  }
  dly;
}
