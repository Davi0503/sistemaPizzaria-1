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
            int contUsuario = 0;
            int menu;

            do{
                //Chamada para o Menu Principal
                ExibirMenuPrincipal();
                //Recebendo a opção escolhida pelo usuário
                menu = int.Parse(Console.ReadLine());

                switch (menu){
                    
                    //Cadastrar usuario
                    case 1:{
                            usuario[contUsuario] = new Usuario();
                            usuario[contUsuario].CadastrarUsuario(usuario[contUsuario]);
                            contUsuario++;
    
                        break;
                    }

                    //Efetuar login
                    case 2:{
                        MenuLogin(usuario);
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
        /// <summary>
        /// Exibindo o Menu Principal da Aplicação
        /// </summary>
        static void ExibirMenuPrincipal()
        {
                Console.WriteLine("Selecione opção desejada");
                Console.WriteLine("[1] - Cadastrar usuário");
                Console.WriteLine("[2] - Efetuar login");
                Console.WriteLine("[3] - Listar usuários");
                Console.WriteLine("[9] - Sair");
        }

        static void MenuLogin(Usuario usuario)
        {
            Console.WriteLine("Informe o seu email: ");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Informe a sua senha: ");
            usuario.Senha = Console.ReadLine();
        }
    }
    //FIM DA CLASSE PROGRAM
}
