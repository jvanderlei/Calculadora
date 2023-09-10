# Calculadora
Resolução de Case para Engenharia de Software JR

Segue explicação para as correções feitas para seus respectivos problemas no codigo:
1. Aplicação só está processando o primeiro item da fila infinitamente. <br/>
R: Por utilizar uma fila, foi preciso trocar o método Peek(), que apenas visualiza o primeiro item da fila, pelo método dequeue, que tira da fila o primeiro objeto. Modifiquei também o loop de maior ou igual a 0 para maior que zero, pois caso o tamanho da fila seja 0, já não teremos mais objetos para serem processados.
2. Implemente a funcionalidade de divisão.<br/>
R: Fiz a simples implementação como um novo método na classe Calculadora
3. Aplicação não está calculando a penultima operação corretamente.<br/>
R: O valor a ser calculado era maior que o valor máximo de uma variável de tipo Int, portanto a soma estava alterando o bit de sinal ao invés de realizar a soma corretamente. A correção foi modificar os campos de ValorA e ValorB para tipo Long, que suporta o tamanho do valor a ser calculado.
4. Implemente uma funcionalidade para imprimir toda a lista de operações a ser processada após cada cálculo realizado.<br/>
R: Adicionei a função printEnumerable que percorre a fila de cálculos e imprime as propriedades já populadas na fila.
5. Crie uma nova pilha (Stack) para guardar o resultado de cada cálculo efetuado e imprima a pilha ao final.<br/>
R: Criei uma pilha que recebe os objetos de Operações após serem processados e implementei a mesma função citada acima, adicionando condição para imprimir também os resultados.

Neste Branch fiz a resolução das questões mantendo o design do sistema. Mas adicionei também uma [branch com a resolução incrementada](https://github.com/jvanderlei/Calculadora/blob/feature/resolucao_incrementada/README.md)


