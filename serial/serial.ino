void setup() {
  Serial.begin(9600);
  Serial.print("Data"); 
}
void loop()
{
  if (Serial.available() > 0) 
  {
    Serial.print(Serial.readString());
  }
}
