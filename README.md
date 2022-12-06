# Trabalho-BD---Queicy-Silas
SISTEMA DE GESTÃO ACADÊMICA SGA

1.	Introdução

O presente documento tem como objetivo realizar o detalhamento das funcionalidades do Sistema de Gestão Acadêmico SGA da Faculdade Fonte do Saber.

1.1.	Visão Geral

O Sistema Gestão Acadêmico SGA é um sistema de informação que auxilia o gerenciamento das informações dos professores que lecionam na faculdade.
O sistema permitirá a inclusão, consulta, alteração e exclusão das informações dos professores; bem como a geração da folha de pagamento da faculdade.

1.2.	Funcionalidades

O sistema deverá auxiliar o usuário em sua gestão oferecendo ferramentas que permitam:

•	Incluir novo professor: Neste caso, deve-se entrar com o código e o nome do professor. O registro possui um campo “título” que deve ser iniciado com “E” (especialista). Em seguida, deve-se entrar com o número de horas semanais e calcular o salário com base na Tabela 1. 
•	Pesquisar dados de um professor: Neste caso, deve-se entrar com o código do professor que se deseja pesquisar. Então, o sistema apresenta os dados do professor em questão. Se o código do professor não existe, deve ser apresentada uma mensagem de erro.
•	Alterar título: Neste caso, deve-se entrar com o código do professor cujo título será alterado.  O sistema então apresenta o título atual. Os títulos possíveis para um professor são: “E” (Especialista), “M” (Mestre) e “D” (Doutor).  Em seguida, deve-se entrar com o novo título do professor. Somente devem ser permitidas alterações de especialista para mestre ou doutor e; de mestre para doutor. Se o código do professor não existe, deve ser apresentada uma mensagem de erro.
•	Excluir professor: Neste caso, deve-se entrar com o código do professor que será removido do sistema. Se o código do professor não existe, deve ser apresentada uma mensagem de erro.
•	Imprimir folha de pagamento: Neste caso, o sistema deve imprimir o contra-cheque de todos os professores da faculdade. O contra-cheque deve possuir os seguintes dados: código, nome, título, horas semanais, salário bruto, valor descontado de INSS, valor descontado de imposto de renda e salário líquido.

Tabela 1		
Título  Hora/Aula
E	      R$ 20.40		
M	      R$ 31.20		
D	      R$ 42.80		
			  

Tabela 2
Cálculos para salário bruto e salário líquido
Salário bruto: Valor hora/aula * Número de horas semanais * 4.5
INSS: 8.5% sobre o salário bruto
IR: 15% sobre o salário bruto - INSS
Salário líquido: Salário bruto – INSS – IR

1.3.	Detalhes de implementação

O sistema foi desenvolvido utilizando a linguagem C# e o SGBD MySQL. A classe Professor apresentada abaixo.
-----------------------
Professor
-----------------------
- código: int
- nome: string
- titulacao: string
- horas: int
-----------------------
+ calcularSalarioBruto(): double
+ calcularInss(): double
+ calcularIr(): double
+ calcularSalarioLiquido(): double
-----------------------
A classe Professor armazena o código, o nome, a quantidade de horas que o professor leciona por semana e sua titulação. Os títulos possíveis para um professor são: Especialista, Mestre e Doutor.

O sistema utiliza o padrão DAO (Data Acess Object). DAO é um padrão de projetos que provê uma interface que abstrai o acesso a dados e encapsula o acesso aos dados, de forma que as demais classes não precisem saber sobre isso. 

