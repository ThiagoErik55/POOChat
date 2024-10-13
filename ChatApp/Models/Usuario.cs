using System.Collections.Generic;

namespace ChatApp.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public List<Mensagem> MensagensEnviadas { get; set; }

        public Usuario()
        {
            MensagensEnviadas = new List<Mensagem>();
        }

        //cadastrar novo usuário
        public void Cadastrar(string nome, string email, string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }

        //fazer login
        public bool Login(string email, string senha)
        {
            return this.Email == email && this.Senha == senha; //validação email
        }
    }
}