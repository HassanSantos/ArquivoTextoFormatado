# ArquivoTextoFormatado
Trabalho Prático
Manipulação de Arquivos Texto
Implemente um programa C# que, enquanto o usuário desejar, realize a leitura do nome, data
de nascimento (dd/mm/aaaa) e o valor do salário de um conjunto de pessoas. A cada iteração,
um registro deverá ser inserido em um arquivo texto formato conforme o layout abaixo.
#
Campo Início Término Tipo Observações
  1 Nome 1 18 Alfa numérico
  2 Data de nascimento 19 26 Numérico ddmmaaaa
  3 Salário 27 35 Numérico Vírgula decimal lógica
Exemplo de um arquivo:
12345678901234567890123456789012345
Maria do Carmo 02101944000153210
João Pedro Farias 23101936000157223
Rejane Costa Silva10031988000035721
Implemente um programa C# em que o usuário informe o caminho de um arquivo texto
formatado, conforme o layout acima.

O programa deverá realizar a leitura de cada linha do arquivo e apresentar os valores
formatados corretamente.
Exemplo da apresentação:
Nome: Maria do Carmo
Data de nascimento: 02/10/1944
Salário: 1.532,10
Nome: João Pedro Farias
Data de nascimento: 23/10/1936
Salário: 1.572,23
Nome: Rejane Costa Silva
Data de nascimento: 10/03/1988
Salário: 357,21
