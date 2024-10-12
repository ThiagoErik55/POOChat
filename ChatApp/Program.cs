using System;
using ChatApp.Models;
using ChatApp.Repositories;

class Program 
{
    static void Main(string[] args)
    {
        Usuario user = new Usuario();
        user.Nome = "João";
        Console.WriteLine($"Usuário {user.Nome} criado com sucesso!");
 
    using (var db = new AppDbContext())
        {
            db.Database.EnsureCreated();
            Console.WriteLine("Banco de dados criado com sucesso!");
        }
    }  
}