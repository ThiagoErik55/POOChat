using System;

namespace ChatApp.Models
{
    public class MensagemArquivo : Mensagem
    {
        public string CaminhoArquivo { get; set; }
        public string TipoArquivo { get; set; }

        public override void Enviar()
        {
            Console.WriteLine($"Arquivo enviado: {CaminhoArquivo}");
        }
    }
}