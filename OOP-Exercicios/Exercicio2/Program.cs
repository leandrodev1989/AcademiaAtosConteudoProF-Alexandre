﻿/*#2
Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

Regras que deverão ser seguidas para a implementação do programa:

Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
É obrigatório criar uma classe para representar o Animal.
A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).*/

using Exercicio2;



class Program
{
    static List<Animal> animais = new List<Animal>();
    static void Main(string[] args)
    {




        for (int i = 0; i < 5; i++)
        {
            bool escolheu = false;
            while (escolheu == false)
            {
                if (escolheu == false)
                {
                    int contadorgato = 0;
                    int contadorcachorro = 0;
                    int contadorpeixe = 0;
                    Console.WriteLine("Entre com os Dados dos  Animais");
                    Console.WriteLine("Digite o nome do Animal");
                    var nome = Console.ReadLine();
                    Console.WriteLine("Digite o Tipo do Animal");
                    var tipo = Console.ReadLine();
                    Console.WriteLine("");

                    if (tipo == "GATO".ToLower() || tipo == "CACHORRO".ToLower() || tipo == "PEIXE".ToLower())
                    {
                        if (tipo == "gato")
                        {
                            contadorgato++;
                        }
                        else if (tipo == "cachorro")
                        {
                            contadorcachorro++;
                        }
                        else if (tipo == "peixe")
                        {
                            contadorpeixe++;
                        }

                        Animal animal = new Animal(nome, tipo, contadorgato, contadorcachorro, contadorpeixe);
                        animais.Add(animal);


                    }
                    else
                    {
                        Console.WriteLine("Tipo de Animal Não Valido!!");

                    }
                }


                escolheu = true;




            }

        }

        Console.WriteLine($"Nome do animal é {nome} | Tipo do animal {contadorgato}");
        Console.WriteLine($"Nome do animal é {nome} | Tipo do animal {contadorcachorro}");
        Console.WriteLine($"Nome do animal é {nome} | Tipo do animal {contadorpeixe}");
    }

        

}      











