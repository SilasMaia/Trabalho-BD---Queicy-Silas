create database folhadepagamento;

use folhadepagamentoqueicy;

CREATE TABLE `professor` (
  `codigo` int NOT NULL,
  `nome` varchar(255) DEFAULT NULL,
  `titulacao` varchar(255) DEFAULT NULL,
  `horas` int DEFAULT NULL,
  PRIMARY KEY (`codigo`)
);