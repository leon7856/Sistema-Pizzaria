#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include <SPI.h>
#include <MFRC522.h>

#define RST_PIN 9
#define SS_PIN 53
#define BUZZER_PIN 8 

MFRC522 rfid(SS_PIN, RST_PIN);
LiquidCrystal_I2C lcd(0x27, 16, 2);

struct Pedido {
  String nomePizza;
  int quantidade;
};

Pedido pedidos[10];
int totalPedidos = 0;
int pedidoAtual = 0;

void setup() {
  Serial.begin(9600);
  SPI.begin();
  rfid.PCD_Init();
  lcd.init();
  lcd.backlight();
  lcd.setCursor(0, 0);
  lcd.print("Esperando pedido");

  pinMode(BUZZER_PIN, OUTPUT);
}

void loop() {
  
  if (Serial.available()) {
    String linha = Serial.readStringUntil('\n');
    int separador = linha.indexOf(';');
    if (separador > 0) {
      String nome = linha.substring(0, separador);
      int qtd = linha.substring(separador + 1).toInt();
      if (totalPedidos < 10) {
        pedidos[totalPedidos++] = {nome, qtd};
        lcd.clear();
        lcd.setCursor(0, 0);
        lcd.print("Pedido recebido");
        bip();
        delay(1500);
        mostrarPedido(pedidoAtual);
      }
    }
  }

 
  if (rfid.PICC_IsNewCardPresent() && rfid.PICC_ReadCardSerial()) {
   

    pedidoAtual++;
    if (pedidoAtual >= totalPedidos) pedidoAtual = 0;
    mostrarPedido(pedidoAtual);
    delay(1000); 
  }
}

void mostrarPedido(int index) {
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print(pedidos[index].nomePizza);
  lcd.setCursor(0, 1);
  lcd.print("Qtd: ");
  lcd.print(pedidos[index].quantidade);
}

void bip() {
  digitalWrite(BUZZER_PIN, HIGH);
  delay(800);
  digitalWrite(BUZZER_PIN, LOW);
}
