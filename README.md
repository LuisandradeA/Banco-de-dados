# Banco-de-dados
Disciplina de Banco de dados do IMD.

Trabalho Primeira Unidade
Considerando o Banco de Dados utilizado na Avaliação 1, implemente um programa que permita
manter os cadastros de Empregados, Dependentes, Departamento, Locais e Projetos. O programa
deve também permitir que Empregados sejam associados a Projetos. O programa deve ainda
possibilitar a emissão de diversos relatórios, utilizando as consultas já discutidas em aula. A
parametrização da consulta deve ser realizada de acordo com a função do relatório

-> Aplicação foi feita utilizando o framework dotnet core e a linguagem C#. Para interagir com o banco de dados postgres, foi utlizado a biblioteca Dapper do dotnet.O projeto utiliza-se do padrão MVC.

-> Não foi feita a funcionalidade de associar um projeto a um empregado, o principio da tela foi feito (DropDownlist contendo os prejetos), mas não finalizado.

-> Relatórios de empregados:
  - Relatório de quais projetos (e seu departamento) o empregado participa.
  - Quais dependentes o empregado está associado.
