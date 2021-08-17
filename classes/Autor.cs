using System;

class Autor {

    private string NomeAutor {get; set;}
    private string Cpf {get; set;}
    private string Email {get; set;}

    public Autor(string nomeAutor, string cpf, string email) {
        this.NomeAutor = nomeAutor;
        this.Cpf = cpf;
        this.Email = email;
    }

    public virtual void ExibeDados() {
        Console.WriteLine($"Dados do autor: \n nome do autor: {NomeAutor} \n cpf: {Cpf} \n email: {Email}");
    }


}