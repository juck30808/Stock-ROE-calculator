int TRIGPIN[3]={13,9,5};
int ECHOPIN[3]={12,8,4};
int CarLed[3]={11,7,3};
int Sound[3]={10,6,2};    //警告聲

//第一組13~10 第二組9~6 第三組5~2
#include "Timer.h" //加裝Timer模組來取得時間間隔
int i,x,x1,cm,cm1,ma,ma1 = 0;
String carnum[4] = {"0","0","0","0"};
String out="";
Timer a;

long ping1() {
  digitalWrite(TRIGPIN[0], LOW);
  delayMicroseconds(2);
  digitalWrite(TRIGPIN[0], HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIGPIN[0], LOW);
  return pulseIn(ECHOPIN[0], HIGH)/58;}
long ping2() {
  digitalWrite(TRIGPIN[1], LOW);
  delayMicroseconds(2);
  digitalWrite(TRIGPIN[1], HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIGPIN[1], LOW);
  return pulseIn(ECHOPIN[1], HIGH)/58;}
  long ping3() {
  digitalWrite(TRIGPIN[2], LOW);
  delayMicroseconds(2);
  digitalWrite(TRIGPIN[2], HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIGPIN[2], LOW);
  return pulseIn(ECHOPIN[2], HIGH)/58;}

void playTone(){
      tone(Sound[0],659,150);
      delay(300);} 
void playTone1(){
      tone(Sound[1],659,150);
      delay(300);} 

void check(){
      static  unsigned long count = 0;
      Serial.print(count);             //編號
      count++;
      Serial.print(",Distance:");
      Serial.print(ping1());           //距離1
      Serial.print("_");
      Serial.print(ping2());           //距離2
      Serial.print("_");
      Serial.print(ping3());           //距離3
      Serial.print("cm,");
      Serial.print("Main:");
      Serial.print(out);               //有無
      Serial.println();}
      
void setup() {
  Serial.begin(9600);
  for(i=0;i<3;i++){
     pinMode(ECHOPIN[i], INPUT);
     pinMode(TRIGPIN[i], OUTPUT);
     pinMode(Sound[i], OUTPUT);
     pinMode(CarLed[i],OUTPUT);
  }
  a.every(1000, check);  //每1秒更新一次資料
}   

void loop() {
  long cm1 = ping1();     //取得距離(得知是否有車)
  long cm2 = ping2();
  long cm3 = ping3();
  for ( int j = 0 ;j<4;j++){
    carnum[j] = "0";
    digitalWrite(CarLed[j], LOW);
  }
  if (cm1 <=6) 
  {
     carnum[1] = "1";
     digitalWrite(CarLed[0], HIGH);
     for(x;x<2 ; x++){           //使警告聲播放2次
      playTone();}
  }
  if (cm2<=6)
  {
     carnum[2] = "1";
     digitalWrite(CarLed[1], HIGH);
     for(x;x<2 ; x++){           //使警告聲播放2次
      playTone1();}
  }
  if (cm3 <=6) 
  {
     carnum[3] = "1";
     digitalWrite(CarLed[2], HIGH);
     for(x;x<2 ; x++){           //使警告聲播放2次
      playTone();}
  }
    out =carnum[1] +carnum[2]+carnum[3];
    delay(1000);
    a.update();
}

// carnum(1) 這個叫function   carnum[1]這個叫陣列
  
  /*舊版程式
  for(i=0;i<2;i++){       //LED顯示是否有人停,預設為無(0)
    digitalWrite(CarLed[i], LOW);
  }
  if (cm1 <=6)
  {
    digitalWrite(CarLed[0], HIGH);
    ma = 1;
      for(x;x<2 ; x++){           //使警告聲播放2次
      playTone();
      }
  }
  if(cm1>=6)
  {
    digitalWrite(CarLed[0], LOW);
    x=0;
  }
  if (cm2 <=6)
  {
    digitalWrite(CarLed[1], HIGH);
    ma1 = 1;
      for(x1;x1<2 ; x1++){           //使警告聲播放2次
      playTone1();
      }
  }
    if(cm2>=6){
      digitalWrite(CarLed[1], LOW);
      x1=0;
    }
  delay(100);
  a.update();
}
*/
