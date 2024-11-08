#define red 8
#define blue 6
#define yellow 4
#define green 2
char data;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(red, OUTPUT);
  pinMode(blue, OUTPUT);
  pinMode(yellow, OUTPUT);
  pinMode(green, OUTPUT);
}

void loop() {
  data = Serial.read();
      switch(data){
        case 'r': digitalWrite(red, HIGH);
                  digitalWrite(blue, LOW);
                  digitalWrite(yellow, LOW);
                  digitalWrite(green, LOW);
                  Serial.println('r');
                  break;
        case 'b': digitalWrite(red, LOW);
                  digitalWrite(blue, HIGH);
                  digitalWrite(yellow, LOW);
                  digitalWrite(green, LOW);
                  break;
        case 'y': digitalWrite(red, LOW);
                  digitalWrite(blue, LOW);
                  digitalWrite(yellow, HIGH);
                  digitalWrite(green, LOW);
                  break;
        case 'g': digitalWrite(red, LOW);
                  digitalWrite(blue, LOW);
                  digitalWrite(yellow, LOW);
                  digitalWrite(green, HIGH);
                  break;
    }
  
}
