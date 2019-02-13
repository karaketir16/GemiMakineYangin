int red_led =8;
int green_led=9;
int deger=A0;
int seviye;

void setup()
{
  Serial.begin(9600);
}
void loop()
{
  seviye  = analogRead(deger);
  Serial.println(seviye);
  delay(500);
}
