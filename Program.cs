using System;
using sistemaPizzaria.Class;

namespace Senai.Projetos.Sistema.Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario[] usuario = new Usuario[100];
            Produto[] produto = new Produto[100];
            int menu;

            do{
                Console.WriteLine("Selecione opção desejada");
                Console.WriteLine("[1] - Cadastrar usuário");
                Console.WriteLine("[2] - Efetuar login");
                Console.WriteLine("[3] - Listar usuários");
                Console.WriteLine("[9] - Sair");
                menu = int.Parse(Console.ReadLine());

                switch (menu){
                    
                    //Cadastrar usuario
                    case 1:{
                        break;
                    }

                    //Efetuar login
                    case 2:{
                        break;
                    }

                    //Listar usuários
                    case 3:{
                        break;
                    }


                    case 9:{
                        Console.WriteLine("Obrigado e volte sempre!");
                        break;
                    }

                    //Opções inválidas                    
                    default:{
                        Console.WriteLine("Opção inválida");
                    break;
                    }

                }

            } while (menu != 9);

        }
    }
}
