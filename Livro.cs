using System;
 class Livro : Autor{
    private string Nome { get; set;}
    private string Descricao {get; set;}
    private double Valor {get; set;}
    private string Isbn {get; set;}
    private Autor Autor {get; set;}

    public Livro (string nome, string descricao, double valor, string isbn, string nomeAutor, string cpf, string email) : base (nomeAutor, cpf, email)
    {
        this.Nome = nome;
        this.Descricao = descricao;
        this.Valor = valor;
        this.Isbn = isbn;
    }

   public void AplicaDescontoDe(double porcentagem) {
       this.Valor -= this.Valor * porcentagem;
   }

   public double RetornaValorDoDesconto(double porcentagem) {
       return this.Valor * porcentagem;
   }

   public override void ExibeDados() {
       base.ExibeDados();
       Console.WriteLine($"Dados do livro: \n nome: {Nome} \n descrição: {Descricao} \n valor: {Valor} \n isbn: {Isbn} \n");
   }

   public string RetornaNomeDoLivro() {
       return this.Nome;
   }


}