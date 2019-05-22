#include <hcsr04.h>
#include "SR04.h"
#define TRIG_PIN 12
#define ECHO_PIN 11
SR04 sr04 = SR04(ECHO_PIN,TRIG_PIN);
long a;
/*
int  sensorPinD  =  7;     // select the input  pin for  the potentiometer
int  sensorPinA  =  A0; 
int  sensorValue =  0;  // variable to  store  the value  coming  from  the sensor
int db;*/

void setup() {
   Serial.begin(19200);
   delay(1000);
   //pinMode(sensorPinD, INPUT);
}

void loop() {
   a=sr04.Distance();
   /*
   sensorValue =  analogRead(sensorPinA);
   if (digitalRead(sensorPinD) == HIGH){
    Serial.println("Bonjour");
   }
   */
   //Serial.println(a);
   Serial.write(a);
   Serial.flush();
   //Serial.println(sensorValue,  DEC);
   //Serial.println("cm");
   delay(100);
}
