#include <DHT.h>
#include <ESP8266WiFi.h>

const char* ssid     = "Orange_Swiatlowod_B18A"; 
const char* password = "RLWW2604991"; 

int pin = 2;

WiFiServer server(80);
DHT dht11;

void setup() {
Serial.begin(115200);
delay(10);
Serial.println();
dht11.setup(pin);
// Connect to WiFi network
WiFi.mode(WIFI_STA);
Serial.println();
Serial.println();
Serial.print("Connecting to ");
Serial.println(ssid);

WiFi.begin(ssid, password);

while (WiFi.status() != WL_CONNECTED) {
delay(500);
Serial.print(".");
}
Serial.println("");
Serial.println("WiFi dziala");

// Start the server
server.begin();

// Print the IP address
Serial.println(WiFi.localIP());
}

void loop() {
 int wilgotnosc = dht11.getHumidity();
 int temperatura = dht11.getTemperature();

WiFiClient client = server.available();
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
