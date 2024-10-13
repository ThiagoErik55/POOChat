using System;

namespace ChatApp.Models
{
    public class MensagemTexto : Mensagem
    {
        public MensagemTexto()
        {
            this.DataEnvio = DateTime.Now;
        }

        public override void Enviar()
        {
            base.Enviar();
            Console.WriteLine($"Texto enviado: {Conteudo}");
        }
    }
} 