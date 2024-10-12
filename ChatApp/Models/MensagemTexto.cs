using System;

namespace ChatApp.Models
{
    public class MensagemTexto : Mensagem
    {
        public MensagemTexto()
        {
            this.DataEnvio = DateTime.Now;
        }
    }
} 