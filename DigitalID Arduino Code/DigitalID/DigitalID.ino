#include <SPI.h>
#include <RFID.h>
#include <LiquidCrystal.h>
#define RS_PIN 2
#define EN_PIN 3
#define DATA4_PIN 4
#define DATA5_PIN 5
#define DATA6_PIN 6
#define DATA7_PIN 7
#define RST_PIN 9
#define SS_PIN 10
#define ADC_IN A0
#define LCD_BACKLIGHT A1
#define INDICATOR_RED A2
#define INDICATOR_GREEN A3
#define BUZZER A4

RFID rfid(SS_PIN,RST_PIN);
char keypressed;
int keyboardValue = 0;
int keypressCount = 0;
char password[1000];
LiquidCrystal lcd(RS_PIN, EN_PIN, DATA4_PIN, DATA5_PIN, DATA6_PIN, DATA7_PIN); /// REGISTER SELECT PIN,ENABLE PIN,D4 PIN,D5 PIN, D6 PIN, D7 PIN

boolean replay = false;
int lcdClearCounter = 0;
String tagID = "";

void setup(){
  SPI.begin();
  rfid.init();
  pinMode(LCD_BACKLIGHT, OUTPUT);
  pinMode(INDICATOR_GREEN, OUTPUT);
  pinMode(INDICATOR_RED, OUTPUT);
  pinMode(BUZZER, OUTPUT);
  lcd.begin(16, 2);
  Serial.begin(115200);
  digitalWrite(INDICATOR_GREEN, HIGH);
  digitalWrite(INDICATOR_RED, HIGH);
}

void loop(){
  keyboardValue = analogRead(ADC_IN);
  if(keyboardValue > 25)
  {
    digitalWrite(LCD_BACKLIGHT, HIGH);
    lcd.clear();
    keypressCount = 0;
    RoutineKeyboard();
  }
  else if(rfid.isCard()){
    digitalWrite(LCD_BACKLIGHT, HIGH);
    lcd.clear();
    RoutineRFID();
  }
  else
  {
    lcd.print("....Welcome....");
    lcd.setCursor(0, 0);
  }
}
void RoutineRFID(){
  if(rfid.readCardSerial())
  {
    for(int i = 0; i < 5; i++)
    {
       tagID+=rfid.serNum[i];
    }
    rfid.halt();
    Serial.println(tagID);

  String feedBack = "";
  if(Serial.available())
  {
    feedBack = Serial.readString();
  }
  
  if(feedBack.substring(feedBack.length()-2) == "")
  {
    lcd.clear();
    lcd.print("Please Try Again");
    
    for(int i = 0; i < 3; i++)
    {
      digitalWrite(INDICATOR_RED, LOW);
      digitalWrite(BUZZER, HIGH);
      delay(200);
      digitalWrite(INDICATOR_RED, HIGH);
      digitalWrite(BUZZER, LOW);
      delay(200);
    } 
  }
  else
  {
    lcd.clear();
    lcd.print(feedBack);
    digitalWrite(INDICATOR_GREEN, LOW);
    digitalWrite(BUZZER, HIGH);
    delay(300);
    digitalWrite(INDICATOR_GREEN, HIGH);
    digitalWrite(BUZZER, LOW);
    delay(3000);
  }
  tagID = "";
}
}
void RoutineKeyboard(){
  keyboardValue = analogRead(ADC_IN);
  if ((keyboardValue >25) && (keyboardValue < 67)){
    keypressed = '1';
    lcd.print(keypressed);
    password[keypressCount] = keypressed; 
    keypressCount++;
  }
  if ((keyboardValue >67) && (keyboardValue < 108)){
    keypressed = '2';
    lcd.print(keypressed);
    password[keypressCount] = keypressed; 
    keypressCount++;
  }
  if ((keyboardValue >108) && (keyboardValue < 162)){
    keypressed = '3';
    lcd.print(keypressed);
    password[keypressCount] = keypressed; 
    keypressCount++;
  }
  if ((keyboardValue >162) && (keyboardValue < 253)){
    keypressed = '4';
    lcd.print(keypressed);
    password[keypressCount] = keypressed; 
    keypressCount++;
  }
  if ((keyboardValue >253) && (keyboardValue < 361)){
    keypressed = '5';
    lcd.print(keypressed);
    password[keypressCount] = keypressed; 
    keypressCount++;
  }
  if ((keyboardValue >361) && (keyboardValue < 479)){
    keypressed = '6';
    lcd.print(keypressed);
    password[keypressCount] = keypressed; 
    keypressCount++;
  }
  if ((keyboardValue >479) && (keyboardValue < 619)){
    keypressed = '7';
    lcd.print(keypressed);
    password[keypressCount] = keypressed; 
    keypressCount++;
  }
  if ((keyboardValue >619) && (keyboardValue < 765)){
    keypressed = '8';
    lcd.print(keypressed);
    password[keypressCount] = keypressed; 
    keypressCount++;
  }
  if ((keyboardValue >765) && (keyboardValue < 819)){
    keypressed = '9';
    lcd.print(keypressed);
    password[keypressCount] = keypressed; 
    keypressCount++;
  }
  if ((keyboardValue >819) && (keyboardValue < 889)){
    keypressed = '*';
    lcd.print(keypressed); 
    keypressCount = 0;
    RefreshPassword();
    lcd.clear();
  }
  if ((keyboardValue >889) && (keyboardValue < 938)){
    keypressed = '0';
    lcd.print(keypressed);
    password[keypressCount] = keypressed; 
    keypressCount++;
  }
  if (keyboardValue >938)
  {
    keypressed = '#';
    password[keypressCount] = keypressed;
    lcd.clear();
    lcd.print("Please Wait...");
    digitalWrite(INDICATOR_RED, LOW);
    String ip(password);
    Serial.println(String(ip));
    String courseName = "";
    if(Serial.available())
    {
      courseName = Serial.readString();
    }
    lcd.clear();
    lcd.print(courseName);
    delay(1000);
    RefreshPassword();
    keypressCount++;
    lcd.clear();

    //    if(courseName.equals(""))
    //    {
    //      lcd.print("Please try again.");
    //      for(int i = 0; i < 3; i++)
    //      {
    //        digitalWrite(INDICATOR_RED, LOW);
    //        digitalWrite(BUZZER, HIGH);
    //        delay(200);
    //        digitalWrite(INDICATOR_RED, HIGH);
    //        digitalWrite(BUZZER, LOW);
    //        delay(200);
    //      } 
    //       digitalWrite(INDICATOR_RED, HIGH);
    //       digitalWrite(BUZZER, LOW); 
    //    }
    //    else
    //    {
    //      lcd.print(courseName);
    ////      if(courseName.length() <= 16)
    ////        lcd.print(courseName);
    ////      else if (courseName.length() > 16 && courseName.length() < 32)
    ////      {
    ////        lcd.print(courseName.substring(0, 16));
    ////        delay(1000);
    ////        lcd.clear();
    ////        lcd.print(courseName.substring(16, 32));
    ////     }
    //      digitalWrite(INDICATOR_GREEN, LOW);
    //      digitalWrite(BUZZER, HIGH);
    //      delay(200);
    //      digitalWrite(INDICATOR_GREEN, HIGH);
    //      digitalWrite(BUZZER, LOW);
    //    }

  }
  delay(350); 

  while(keypressed != '#'){
    RoutineKeyboard();
  }

}
String SerialRead(){

}
void RefreshPassword()
{
  for(int i = 0; i < sizeof(password); i++)
  {
    password[i] = '\0';
  }
}

//   //Serial.println(keypressed);      // print the value back to the Serial view window on your PC
//   //delay(1000);                     // wait 1000 milliseconds before the next loop
//
//
//////read the keyboard routine
////
////   //end of read the keyboard routine
//
//void loop()
//{
//  if(rfid.isCard())
//  {
//    if(rfid.readCardSerial())
//    {
//      lcd.clear();
//      lcd.print(rfid.serNum[0]);
//      //lcd.print(",");
//      lcd.print(rfid.serNum[1]);
//      //lcd.print(",");
//      lcd.print(rfid.serNum[2]);
//      //lcd.print(",");
//      lcd.print(rfid.serNum[3]);
//      //lcd.print(",");
//      lcd.print(rfid.serNum[4]);
//      //lcd.println("");
//    }
//    //delay(3000);
//    //lcd.clear();
//  }
// else
//  
//    rfid.halt();
//}
//////  if(key)
//////  {
//////    replay = true;
//////    lcdClearCounter++;
//////  }
//////
//////  if(replay)
//////  {
//////    if(lcdClearCounter == 1)
//////    {
//////      lcd.clear();
//////      lcdClearCounter++;
//////    }
//////    switch (key)
//////    {
//////    case '1':
//////      lcd.print(key);
//////      inputCode[inputCount] = key;
//////      inputCount++;
//////      break;
//////
//////    case '2':
//////      lcd.print(key);
//////      inputCode[inputCount] = key;
//////      inputCount++;
//////      break;
//////
//////    case '3':
//////      lcd.print(key);
//////      inputCode[inputCount] = key;
//////      inputCount++;
//////      break;
//////
//////    case '4':
//////      lcd.print(key);
//////      inputCode[inputCount] = key;
//////      inputCount++;
//////      break;
//////
//////    case '5':
//////      lcd.print(key);
//////      inputCode[inputCount] = key;
//////      inputCount++;
//////      break;
//////
//////    case '6':
//////      lcd.print(key);
//////      inputCode[inputCount] = key;
//////      inputCount++;
//////      break;
//////
//////    case '7':
//////      lcd.print(key);
//////      inputCode[inputCount] = key;
//////      inputCount++;
//////      break;
//////
//////    case '8':
//////      lcd.print(key);
//////      inputCode[inputCount] = key;
//////      inputCount++;
//////      break;
//////
//////    case '9':
//////      lcd.print(key);
//////      inputCode[inputCount] = key;
//////      inputCount++;
//////      break;
//////
//////    case '0':
//////      lcd.print(key);
//////      inputCode[inputCount] = key;
//////      inputCount++;
//////      break;
//////
//////    case '*':
//////      lcd.print(key);
//////      replay = false;
//////      lcdClearCounter = 0;
//////      RefreshInpCode();
//////      inputCount = 0;
//////      lcd.clear();
//////      lcd.print("Welcome...");
//////      lcd.setCursor(0, 0);
//////      break;
//////
//////    case '#':
//////      lcd.print(key);
//////      replay = false;
//////      lcdClearCounter = 0;
//////      lcd.clear();
//////      String ip(inputCode);
//////      Serial.println(String(ip));
//////      lcd.clear();
//////      RefreshInpCode();
//////      inputCount = 0;
//////      break;
//////    }
//// // }
////
//// 
////}
//
//  //  lcd.scrollDisplayLeft();//shifting data on LCD







