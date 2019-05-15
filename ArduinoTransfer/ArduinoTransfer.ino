#include "SR04.h"
#define TRIG_PIN 12
#define ECHO_PIN 11
SR04 sr04 = SR04(ECHO_PIN,TRIG_PIN);
long a;

int  sensorPin  =  A0;     // select the input  pin for  the potentiometer 
int  sensorValue =  0;  // variable to  store  the value  coming  from  the sensor
int db;

void setup() {
   Serial.begin(9600);
   delay(1000);
}

void loop() {
   a=sr04.Distance();
   sensorValue =  analogRead(sensorPin);
   //Serial.write(a);
   Serial.flush();
   //Serial.println(a); 
   Serial.println(sensorValue,  DEC);
   //Serial.println("cm");
   delay(100);
}


}
void loop(){

}
