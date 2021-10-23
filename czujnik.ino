#include <DHT.h>
#include <ESP8266WiFi.h>

const char* ssid     = "Android";  // ssid sieci
const char* password = "12345678";  // haslo
int pin = 2;
WiFiServer server(80);
DHT dht11; // nazwa zmiennej dla czujnika

void setup() {
Serial.begin(115200); // predkosc przesylu
delay(10);
Serial.println();
dht11.setup(pin); // ustawienie pinu 2 dla czujnika
WiFi.mode(WIFI_STA); // inicjalizacja wifi
Serial.println();
Serial.println();
Serial.print("Connecting to "); // wypisanie ssid i hasla
Serial.println(ssid);
WiFi.begin(ssid, password);
while (WiFi.status() != WL_CONNECTED) 
  {
  delay(500);
  Serial.print("."); // oczekiwanie na połączenie
  }
Serial.println("");
Serial.println("WiFi dziala");
server.begin(); // start serwera
Serial.println(WiFi.localIP()); // wypisanie adresu ip serwera
}

void loop() {
 int wilgotnosc = dht11.getHumidity(); //  ustawienie wartosci z czujnika 
 int temperatura = dht11.getTemperature(); 

WiFiClient client = server.available(); // wczytanie fragmentu kodu html z warunkiem pokazania błędu odczytu.
client.println("HTTP/1.1 200 OK");
client.println("Content-Type: text/html");
client.println("Connection: close");
client.println("Refresh: 5");
client.println();
client.println("<!DOCTYPE html>");
client.println("<html xmlns='http://www.w3.org/1999/xhtml'>");
client.println("<head>\n<meta charset='UTF-8'>");
client.println("<title>Programowanie Aplikacyjne - Projekt</title>");
client.println("</head>\n<body>");
client.println("<H3>Wilgotnosc / Temperatura</H3>");
client.println("<pre>");

if ( temperatura > 50){
  client.println("błąd odczytu");
  client.println("</pre>");
client.print("</body>\n</html>");
}
else{
  client.print("Wilgotnosc (%)    : ");
client.println((float)wilgotnosc, 1);
client.print("Temperatura (°C)  : ");
client.println((float)temperatura, 1);
client.println("</pre>");
client.print("</body>\n</html>");}
 delay(1000);
}
