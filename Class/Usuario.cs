using System;
namespace sistemaPizzaria.Class

{
    public class Usuario
    {
        #region Propriedade
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCriacao { get; set; }
        #endregion


        #region Métodos

        /// <summary>
        /// Método para verificar se o email informado possuí o caracter @
        /// </summary>
        /// //Email informado pelo usuário
        /// <param name="email"></param>
        public void ValidarEmail(string email)
        {
            if(email.Contains("@"))
            {
                Console.WriteLine("Email válido!");
            }
            else
            {
                Console.WriteLine("Digite um email válido");
            }
        } 

        /// <summary>
        /// Verifica se a senha possui mais de 6 digitos
        /// </summary>
        /// <param name="senha"></param>
        public void ValidarSenha(string senha)
        {
            if(senha.Length >= 6)
            {
                Console.WriteLine("Login Efetuado com sucesso! ");
            }
            else
            {
                Console.WriteLine("Senha inválida! ");
            }
        }
        #endregion
    }
}