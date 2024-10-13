using System;
using Microsoft.EntityFrameworkCore;
using ChatApp.Models;
using ChatApp.Repositories;

class Program 
{
    static void Main(string[] args)
    {
        using (var db = new AppDbContext())
        {
            db.Database.Migrate();

            Usuario user = new Usuario();
            user.Cadastrar("João", "joao@gmail.com", "senha123");

            db.Usuarios.Add(user);
            db.SaveChanges();
            Console.WriteLine($"Usuário {user.Nome} criado com sucesso!");

            MensagemTexto mensagem = new MensagemTexto();
            mensagem.Conteudo = "Olá, mensagem teste!";
            mensagem.RemetenteID = user.ID;
            mensagem.DestinatarioID = 2; //exemplo de ID
    
            db.MensagensTexto.Add(mensagem);
            db.SaveChanges();
            Console.WriteLine("Mensagem de texto enviada com sucesso!");
        }
    }  
}