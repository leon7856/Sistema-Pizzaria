-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.32-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.10.0.7000
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Copiando dados para a tabela bd_pizzzaria.clientes: ~32 rows (aproximadamente)
DELETE FROM `clientes`;
INSERT INTO `clientes` (`id`, `nome`, `endereco`) VALUES
	(28, 'Luan', 'Gonzaga'),
	(29, 'Ivan', 'Vila'),
	(30, 'Ana', 'Mathias'),
	(31, 'Leticia', 'Ble'),
	(32, 'Enzo', 'jhh'),
	(33, 'Gustavo', 'jsjsh'),
	(34, 'asd', 'das'),
	(35, 'dasda', 'dasdasd'),
	(36, 'asdasd', 'asdasd'),
	(37, 'asdasd', 'asdas'),
	(38, 'nataly', 'marcelo'),
	(39, 'marcelo', 'cascas'),
	(40, 'adsdas', 'asdad'),
	(41, 'luan', 'hasd'),
	(42, 'dasda', 'dasda'),
	(43, 'asda', 'dasd'),
	(44, 'asdasdasd', 'asdasd'),
	(45, 'asd', 'dasdas'),
	(46, 'sdasda', 'dasda'),
	(47, 'ASDAS', 'DASDA'),
	(48, 'asda', 'dasda'),
	(49, 'asdasd', 'dasdasd'),
	(50, 'asdasd', 'dasdasd'),
	(51, 'asdas', 'dasda'),
	(52, 'qqasd', 'dasd'),
	(53, 'asdasd', 'asdsd'),
	(54, 'asdasdasd', 'asdasd'),
	(55, 'asdasdasda', 'asdasdasd'),
	(56, 'XzXzCZX', 'fasdfasd'),
	(57, 'Enir', 'Batista Pereira'),
	(58, 'Marcelo', 'Marcelo'),
	(59, 'Enir', 'asdasd'),
	(60, 'DASDA', 'DASDA'),
	(61, 'Marcio', 'Rua Batista Pereira, 10');

-- Copiando dados para a tabela bd_pizzzaria.itens_pedido: ~32 rows (aproximadamente)
DELETE FROM `itens_pedido`;
INSERT INTO `itens_pedido` (`id`, `id_pedido`, `nome_pizza`, `quantidade`, `valor`, `exibido`) VALUES
	(34, 28, 'Mussarela', 1, 20.00, 0),
	(35, 29, 'Mussarela', 1, 20.00, 0),
	(36, 30, 'Mussarela', 1, 20.00, 0),
	(37, 31, 'Calabresa', 2, 60.00, 0),
	(38, 32, 'Mussarela', 1, 20.00, 0),
	(39, 33, 'Calabresa', 3, 90.00, 0),
	(40, 34, 'Frango', 1, 40.00, 0),
	(41, 35, 'Brigadeiro', 1, 10.00, 0),
	(42, 36, 'Portuguesa', 2, 60.00, 0),
	(43, 37, 'Dois Queijos', 1, 45.00, 0),
	(44, 38, 'Mussarela', 1, 20.00, 0),
	(45, 39, 'Calabresa', 2, 60.00, 0),
	(46, 40, 'Brigadeiro', 1, 10.00, 0),
	(47, 41, 'Mussarela', 1, 20.00, 0),
	(48, 42, 'Calabresa', 6, 180.00, 0),
	(49, 43, 'Mussarela', 1, 20.00, 0),
	(50, 44, 'Calabresa', 2, 60.00, 0),
	(51, 45, 'Mussarela', 1, 20.00, 0),
	(52, 46, 'Calabresa', 3, 90.00, 0),
	(53, 47, 'Mussarela', 1, 20.00, 0),
	(54, 48, 'Portuguesa', 1, 30.00, 0),
	(55, 49, 'Calabresa', 1, 30.00, 0),
	(56, 50, 'Calabresa', 1, 30.00, 0),
	(57, 51, 'Mussarela', 1, 20.00, 0),
	(58, 52, 'Mussarela', 1, 20.00, 0),
	(59, 53, 'Calabresa', 7, 210.00, 0),
	(60, 54, 'Mussarela', 1, 20.00, 0),
	(61, 55, 'Calabresa', 4, 120.00, 0),
	(62, 56, 'Mussarela', 1, 20.00, 0),
	(63, 57, 'Mussarela', 1, 20.00, 0),
	(64, 57, 'Mussarela', 1, 20.00, 0),
	(65, 58, 'Mussarela', 1, 20.00, 0),
	(66, 59, 'Calabresa', 3, 90.00, 0),
	(67, 60, 'Portuguesa', 2, 60.00, 0),
	(68, 61, 'Mussarela', 1, 20.00, 0),
	(69, 61, 'Portuguesa', 1, 30.00, 0);

-- Copiando dados para a tabela bd_pizzzaria.pedidos: ~32 rows (aproximadamente)
DELETE FROM `pedidos`;
INSERT INTO `pedidos` (`id`, `id_cliente`, `valor_total`, `data_pedido`) VALUES
	(28, 28, 20.00, '2025-06-05 15:14:38'),
	(29, 29, 20.00, '2025-06-05 15:47:58'),
	(30, 30, 20.00, '2025-06-05 15:58:56'),
	(31, 31, 60.00, '2025-06-05 15:59:19'),
	(32, 32, 20.00, '2025-06-05 16:01:33'),
	(33, 33, 90.00, '2025-06-05 16:03:47'),
	(34, 34, 40.00, '2025-06-05 16:09:41'),
	(35, 35, 10.00, '2025-06-05 16:11:56'),
	(36, 36, 60.00, '2025-06-05 16:12:38'),
	(37, 37, 45.00, '2025-06-05 16:13:08'),
	(38, 38, 20.00, '2025-06-05 22:30:54'),
	(39, 39, 60.00, '2025-06-05 22:31:13'),
	(40, 40, 10.00, '2025-06-05 22:31:28'),
	(41, 41, 20.00, '2025-06-05 22:35:18'),
	(42, 42, 180.00, '2025-06-05 22:35:38'),
	(43, 43, 20.00, '2025-06-05 22:58:03'),
	(44, 44, 60.00, '2025-06-05 22:58:19'),
	(45, 45, 20.00, '2025-06-05 23:01:56'),
	(46, 46, 90.00, '2025-06-05 23:02:07'),
	(47, 47, 20.00, '2025-06-05 23:06:37'),
	(48, 48, 30.00, '2025-06-05 23:06:49'),
	(49, 49, 30.00, '2025-06-05 23:08:04'),
	(50, 50, 30.00, '2025-06-05 23:09:41'),
	(51, 51, 20.00, '2025-06-05 23:09:48'),
	(52, 52, 20.00, '2025-06-05 23:12:42'),
	(53, 53, 210.00, '2025-06-05 23:12:57'),
	(54, 54, 20.00, '2025-06-05 23:14:43'),
	(55, 55, 120.00, '2025-06-05 23:15:12'),
	(56, 56, 20.00, '2025-06-05 23:18:43'),
	(57, 57, 40.00, '2025-06-06 00:20:51'),
	(58, 58, 20.00, '2025-06-06 00:23:03'),
	(59, 59, 90.00, '2025-06-06 00:23:19'),
	(60, 60, 60.00, '2025-06-06 00:24:04'),
	(61, 61, 50.00, '2025-06-13 14:17:45');

-- Copiando dados para a tabela bd_pizzzaria.produtos: ~6 rows (aproximadamente)
DELETE FROM `produtos`;
INSERT INTO `produtos` (`id`, `nome`, `preco`) VALUES
	(3, 'Mussarela', 20.00),
	(4, 'Calabresa', 30.00),
	(5, 'Frango', 40.00),
	(6, 'Brigadeiro', 10.00),
	(7, 'Portuguesa', 30.00),
	(8, 'Dois Queijos', 45.00),
	(9, 'Enir', 50.00);

-- Copiando dados para a tabela bd_pizzzaria.tb_usuario: ~0 rows (aproximadamente)
DELETE FROM `tb_usuario`;
INSERT INTO `tb_usuario` (`id`, `usuario`, `senha`, `nivel`) VALUES
	(1, 'Leon', '123', 2);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
