
// 讀取光敏電阻讀值並列印到 Serial Port 

int photocellPin = 2; // 光敏電阻 (photocell) 接在 analog pin 2 上
int photocellVal = 0; // 光敏電阻讀值變數

void setup() {
  // 開啟 Serial Port, 通訊速率為 9600bps (Bits Per Second)
  Serial.begin(9600);
}

void loop() {
  // 讀取光敏電阻並輸出到 Serial Port 
  photocellVal = analogRead(photocellPin);
  Serial.println(photocellVal);  
  
  delay(100);       
}

