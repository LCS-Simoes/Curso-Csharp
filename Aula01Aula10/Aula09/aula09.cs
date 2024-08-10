using System;
using Internal;

class aula09{
    static void Main(){
        int num = 30;

        num = num << 3;

        Console.WriteLine(num);
    }
}

/*
    ~~ BITWISE ~~
    << Dobra o valor da variavel  ~~> Vão deslocar 5 bits para esquerda.
    >> Diminui o valor pela metade ~~> Desloca os 5 últimos bits e desloca para a direita, 
    e o ultimo bit é eliminado
    Na programação para dobrar o valor utilizamos o << e o número após para demonstrar quantos
    será seu deslocamento.
    Ex de 3:
    30 << 60 << 120 << 240
*/