int TRIGPIN[2]={13,9};
int ECHOPIN[2]={12,8};
int Sound[2]={11,7};    //警告聲
int CarLed[2]={10,6};
//順序左到右Tri/Echo/Sound/Led,第一組13~10 第二組9~6
#include "Timer.h" //加裝Timer模組來取得時間間隔
int i,x,x1,cm,cm1,ma,ma1 = 0;
Timer a;

long ping() {
  digitalWrite(TRIGPIN[0], LOW);
  delayMicroseconds(2);
  digitalWrite(TRIGPIN[0], HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIGPIN[0], LOW);
  return pulseIn(ECHOPIN[0], HIGH)/58;}

  long ping1() {
  digitalWrite(TRIGPIN[1], LOW);
  delayMicroseconds(2);
  digitalWrite(TRIGPIN[1], HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIGPIN[1], LOW);
  return pulseIn(ECHOPIN[1], HIGH)/58;}
  
void check(){
      static  unsigned long count = 0;
      Serial.print(count); // 從0開始輸出，每次加1
      count++;
      Serial.print(",distance:");
      Serial.print(ping());
      Serial.print("_");
      Serial.print(ping1());
      Serial.print("cm,");
      Serial.print("Main:");
      Serial.print(ma);
      Serial.print(ma1);
      Serial.println();}

void playTone(){
      tone(Sound[0],659,150);
      delay(300);} 

void playTone1(){
      tone(Sound[1],659,150);
      delay(300);} 
      
void setup() {
  Serial.begin(9600);
  for(i=0;i<2;i++){
  pinMode(ECHOPIN[i], INPUT);
  pinMode(TRIGPIN[i], OUTPUT);
  pinMode(Sound[i], OUTPUT);
  pinMode(CarLed[i],OUTPUT);}
  a.every(1000, check); //每1秒更新一次資料
}

void loop() {
  long cm = ping();     //取得車子距離(得知是否有車)
  long cm1 = ping1();
  ma= 0;
  ma1=0;
  for(i=0;i<2;i++){//LED顯示是否有人停,預設為無(0)
  digitalWrite(CarLed[i], LOW);
  }
    if (cm <=6){
      digitalWrite(CarLed[0], HIGH);
      ma = 1;
        for(x;x<2 ; x++){           //使警告聲播放2次
        playTone();
        }
    }
    if(cm>=6){
      digitalWrite(CarLed[0], LOW);
      x=0;
    }

    
     if (cm1 <=6){
      digitalWrite(CarLed[1], HIGH);
      ma1 = 1;
        for(x1;x1<2 ; x1++){           //使警告聲播放2次
        playTone1();
        }
    }
    if(cm1>=6){
      digitalWrite(CarLed[1], LOW);
      x1=0;
    }
  delay(100);
  a.update();
}
