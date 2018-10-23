using System;
namespace sistemaPizzaria.Class

{
    public class Usuario
    {
        #region Propriedade
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; }
        #endregion


        #region Métodos

        /// <summary>
        /// Método para verificar se o email informado possuí o caracter @
        /// </summary>
        /// //Email informado pelo usuário
        /// <param name="email"></param>
        public bool ValidarEmail(string Email)
        {
            if(Email.Contains("@"))
            {
                Console.WriteLine("Email válido!");
                return true;
            }
            else
            {
                Console.WriteLine("Digite um email válido");
                return false;
            }

        }

        /// <summary>
        /// Método para cadastrar o email
        /// </summary>
        public void CadastrarUsuario(Usuario usuario){
                Console.WriteLine("Digite o seu nome");
                Nome = Console.ReadLine();

                Console.WriteLine("Digite o seu Email");
                Email = Console.ReadLine();
                usuario.ValidarEmail(Email);
                bool validarEmail = ValidarEmail(Email);
                while(!validarEmail){
                    Email = Console.ReadLine();
                    usuario.ValidarEmail(Email);
                }

                Console.WriteLine("Digite a sua senha");
                Senha = Console.ReadLine();
                usuario.ValidarSenha(Senha);
                bool validarSenha = ValidarSenha(Senha);
                while(!validarSenha){
                    Senha = Console.ReadLine();
                    usuario.ValidarSenha(Senha);
                }

        } 

        /// <summary>
        /// Verifica se a senha possui mais de 6 digitos
        /// </summary>
        /// <param name="senha"></param>
        public bool ValidarSenha(string senha)
        {
            if(senha.Length >= 6)
            {
                Console.WriteLine("Login Efetuado com sucesso! ");
                return true;
            }
            else
            {
                Console.WriteLine("Senha inválida! ");
                return false;
            }
        }

        #endregion
    }
}