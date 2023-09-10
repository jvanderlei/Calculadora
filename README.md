# Calculadora
Incremento de Resolução de Case para Engenharia de Software JR

Segue explicação para as modificações feitas além do que solicitado:
No case, as operações matematicas estavam sendo executadas em um unico arquivo. Implementei o [Design Pattern de Command](https://refactoring.guru/design-patterns/command) para assim, facilitar a organização do código caso necessitamos adicionar outras operações e diminuir a chance de efeitos colaterais em modificações futuras. A utilização de deste Pattern também auxilia a respeitar o principio de responsabilidade unica do SOLID. 

