using System;


class aula19
{
    static void Main(){ 
        string[] nomes = new string[3];
        int i;

        for(i = 0; i < 3; i++){
            Console.WriteLine("Digite o nome {0}: ", i + 1);
            nomes[i] = Console.ReadLine();
        }

        Console.WriteLine("Nomes digitados foram");

        for(i = 0; i < nomes.Length; i++){
            Console.WriteLine(nomes[i]);
        }

    }
}


/*
    ~~> A Aula era sobre for, mas ja tenho experiencia em C e Java.
    Observação: 
    for(i = 0; i < 3; i++)
    Eu poderia usar no lugar do três < nomes.Lenght, assim nunca vamos
    errar o tamanho do array
*/
