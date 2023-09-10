# Calculadora
Incremento de Resolução de Case para Engenharia de Software JR

Segue explicação para as modificações feitas além do que solicitado:
No case, as operações matemáticas estavam sendo executadas em um único arquivo. Implementei o [Design Pattern de Command](https://refactoring.guru/design-patterns/command) para facilitar a organização do código caso necessitemos adicionar outras operações e diminuir a chance de efeitos colaterais em modificações futuras. A utilização deste Pattern também auxilia a respeitar o principio de responsabilidade única do SOLID. 

