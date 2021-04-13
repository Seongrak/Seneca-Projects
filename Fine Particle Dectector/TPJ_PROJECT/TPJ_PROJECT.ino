
//LCD setting
#include <Wire.h>
#include <LiquidCrystal_I2C.h>               
LiquidCrystal_I2C lcd(0x27, 16, 2);

//DHT11 Temperture, humidity sensor setting
#include "DHT.h"                
#define DHTPIN 8                
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);

//PMS7003 Dust sensor setting
#include <SoftwareSerial.h>
SoftwareSerial dustSerial(2, 3);

//HC-06 Bluetooth setting
SoftwareSerial btSerial(12,13);


void setup() {
  Serial.begin(9600);        
  dustSerial.begin(9600);
  btSerial.begin(9600);
  lcd.begin();  
}

void loop() { 
  static int CheckFirst=0;
  static int pm_add[3][5]={0,};
  static int pm_old[3]={0,};
  int chksum=0,res=0;;
  unsigned char pms[32]={0,};

  dustSerial.listen();
  
  // Calculating the amount of each dust level from the sensor
  if(dustSerial.available()>=32){

    for(int j=0; j<32 ; j++){
      pms[j]=dustSerial.read();
      if(j<30)
        chksum+=pms[j];
    }

    if(pms[30] != (unsigned char)(chksum>>8) 
        || pms[31]!= (unsigned char)(chksum) ){

      return res;
    }
    if(pms[0]!=0x42 || pms[1]!=0x4d )
      return res;
      
  int pms10 = pms[10]*10+pms[11];
  int pms25 = pms[12]*10 +pms[13];
  int pms100 = pms[14]*10+pms[15];

  //Reading humidity from the sensor
  int h = dht.readHumidity();     

  //Reading temperature from the sensor
  int t = dht.readTemperature();

  //Setting the LCD display
  lcd.clear();

  //Shwing the output on the LCD dispaly
  lcd.setCursor(0, 0);
  lcd.print("Humidity: ");
  lcd.print(h);
  lcd.print(" %  ");
  lcd.setCursor(0, 1);
  lcd.print("Temp: ");
  lcd.print(t);
  lcd.print(" C");
  delay(3000);
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("Dust Sensing");
  lcd.setCursor(0, 1);
  lcd.print("PM10: ");
  lcd.print(pms10);
  lcd.print("ug");
  delay(3000);
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("PM2.5: ");
  lcd.print(pms25);
  lcd.print("ug");
  lcd.setCursor(0, 1);
  lcd.print("PM1.0: ");
  lcd.print(pms100);
  lcd.print("ug");
  delay(3000);

  //Connecting bluetooth through serial communication
  btSerial.listen();

  //Sending the humidty data through bluetooth
  btSerial.print(h);

  //Sending the temperature data through bluetooth
  btSerial.print(t);

  //Sending the fine particle data through bluetooth
    if(pms10<100)
    { 
      if(pms10<10)
      { 
        btSerial.print(0);
        btSerial.print(0);
        btSerial.print(pms10);
      }
      else
      {
        btSerial.print(0);
        btSerial.print(pms10);
      }
      
    }
    else
      btSerial.print(pms10);

  
    if(pms25<100)
    { 
      if(pms25<10)
      { 
        btSerial.print(0);
        btSerial.print(0);
        btSerial.print(pms25);
      }
      else
      {
        btSerial.print(0);
        btSerial.print(pms25);
      }
      
    }
    else
      btSerial.print(pms25);

    if(pms100<100)
    { 
      if(pms100<10)
      { 
        btSerial.print(0);
        btSerial.print(0);
        btSerial.print(pms100);
      }
      else
      {
        btSerial.print(0);
        btSerial.print(pms100);
      }
      
    }
    else
      btSerial.print(pms100);

    //LED setting

  // When the air quality is good - BLUE
  if (pms10 < 25) {                 
      digitalWrite(9,30);
      digitalWrite(10,0);
      digitalWrite(11,0);
  }

  // When the air quality is medium - GREEN
  if (pms10 > 25 & pms25 < 50) {    
     digitalWrite(9,0);
     digitalWrite(10,30);
     digitalWrite(11,0);
  }

  // When the air quality is bad - RED
  if (pms100 > 70) {                
    digitalWrite(9,0);
    digitalWrite(10,0);
    digitalWrite(11,30);
  }

    dustSerial.listen();

  }  
}
