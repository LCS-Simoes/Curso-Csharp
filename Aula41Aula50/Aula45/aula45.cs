using System;

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public void Info()
    {
        Console.WriteLine("Marca: {0}, Modelo: {1}, Cor: {2}", this.marca, this.modelo, this.cor);
        Console.WriteLine("-----------------------------------------------");
    }
}

class Aula45
{
    static void Main()
    {
        // Declarando a struct como array
        Carro[] carros = new Carro[5];  

        // Atribuindo valores aos carros
        for (int i = 0; i < carros.Length; i++)
        {
            Console.WriteLine("Digite a marca do carro:  ");
            carros[i].marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo do carro: ");
            carros[i].modelo = Console.ReadLine();
            Console.WriteLine("Digite a cor do carro: ");
            carros[i].cor = Console.ReadLine();
        }

        // Exibindo informações dos carros
        Console.WriteLine("Informações dos carros:");
        for (int i = 0; i < carros.Length; i++)
        {
            carros[i].Info();
        }
    }
}
