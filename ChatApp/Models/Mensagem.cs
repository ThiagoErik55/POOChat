using System;

namespace ChatApp.Models
{
    public class Mensagem
    {
        public int ID { get; set; }
        public string Conteudo { get; set;}
        public DateTime DataEnvio { get; set; }
        public int RemetenteID { get; set; }
        public int DestinatarioID { get; set; }

        public virtual void Enviar()
        {
            Console.WriteLine($"Mensagem enviada: {Conteudo}");
        }
    }
}