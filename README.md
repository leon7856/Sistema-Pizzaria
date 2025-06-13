# 🍕 Sistema de Pizzaria

Sistema interno desenvolvido para facilitar o gerenciamento de pedidos, cardápio e funcionários em uma pizzaria. Integrado com banco de dados e Arduino para exibição física dos pedidos.

## 🔧 Tecnologias Utilizadas
- Visual Studio (C# - Windows Forms)
- Banco de Dados: HeidiSQL + XAMPP (MySQL)
- Arduino UNO
  - Módulo LCD I2C
  - Leitor RFID RC522

## ⚙️ Funcionalidades

### Pedidos
- Realizar pedidos com nome, endereço, pizza(s) e quantidade
- Soma automática do valor total
- Permite adicionar várias pizzas no mesmo pedido
- Visualização de todos os pedidos feitos

### Cardápio
- Adicionar novas pizzas
- Atualizar pizzas existentes
- Remover pizzas
- Visualizar todo o cardápio

### Administração
- Adicionar/remover funcionários
- Visualizar lista de funcionários

### Integração com Arduino
- Ao realizar um pedido, o nome e a quantidade da pizza aparecem no display LCD I2C
- Para exibir a próxima pizza, é necessário passar um cartão RFID
- Comunicação entre sistema e Arduino feita via porta serial

## 💾 Banco de Dados
Todos os dados são armazenados em MySQL, utilizando o HeidiSQL como interface de gerenciamento e o XAMPP para o servidor local.

[Uploading bd_pizzaria.sql…]()

Para importar:
1. Abra o HeidiSQL ou phpMyAdmin.
2. Crie um banco com o nome `bd_pizzaria`.
3. Importe o arquivo `bd_pizzaria.sql`.

## 📸 Interface 
![image](https://github.com/user-attachments/assets/b6556e7f-ad68-4b06-8890-97eb38a0039c)
![image](https://github.com/user-attachments/assets/6cab092e-794a-4767-86aa-5e94c2e3fa74)
![image](https://github.com/user-attachments/assets/1fc5fc2b-e2da-435c-906c-706fbcd05503)


## 📁 Como Executar
1. Clone este repositório:
2. Abra o projeto no Visual Studio.
3. Configure a conexão com o banco de dados no código.
4. Compile e execute.
