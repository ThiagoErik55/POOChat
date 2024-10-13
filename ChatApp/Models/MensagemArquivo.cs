using System;

namespace ChatApp.Models
{
    public class MensagemArquivo : Mensagem
    {
        public string CaminhoArquivo { get; set; } = string.Empty;
        public string TipoArquivo { get; set; } =string.Empty;

        public override void Enviar()
        {
            Console.WriteLine($"Arquivo enviado: {CaminhoArquivo}");
        }
    }
}