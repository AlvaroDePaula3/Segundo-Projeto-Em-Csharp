using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao laboratório pokémon ! Pressione A pra escolher o pokémon ou E pra sair do laboratório.");
            char inicial = Console.ReadKey(true).KeyChar;
            if (inicial == 'A' || inicial == 'a')
            {
                Console.WriteLine(" Escolha seu pokémon inicial.");
                Console.WriteLine("Pressione A pra escolher o Bulbasaur.");
                Console.WriteLine("Pressione B pra escolher o Charmander.");
                Console.WriteLine("Pressione C pra escolher o Squirtle.");
                char pokemonInicial = Console.ReadKey(true).KeyChar;
                switch (pokemonInicial)
                {
                    case 'a':
                        Console.WriteLine(" Você escolheu o inicial Bulbasaur !!!");
                        break;
                    case 'b':
                        Console.WriteLine(" Você escolheu o inicial Charmander !!!");
                        break;
                    case 'c':
                        Console.WriteLine(" Você escolheu o inicial Squirtle !!!");
                        break;
                    case 'p':
                        Console.WriteLine(" Você escolheu o inicial Pikachu !!!");
                        break;
                    default:
                        Console.WriteLine(" Nós não temos esse pokémon");
                        break;
                }

            }
            else if(inicial == 'E' || inicial == 'e')
            {
                Console.WriteLine(" Aguardaremos seu retorno quando se sentir mais preparado para o mundo pokémon! ");
            } else
            {
                Console.WriteLine(" Selecione uma opção conhecida pelo sistema! ");
            }
            Console.WriteLine(" Aperte qualquer botão para sair.");
            Console.ReadKey();
        }
    }
}
