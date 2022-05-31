int i;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);//inicializar el puerto serial a 9600 baudios por segundo
  i = -91;
}

void loop() {
  // put your main code here, to run repeatedly:
  i++;    //incrementa el número i
  Serial.println(i); //Escribir datos en el puerto serial
 
  //Serial.println("hola");  // \n
  if(i==90)
    i=-91;
    
  delay(50); //hacer pausas en milisegundos
}
