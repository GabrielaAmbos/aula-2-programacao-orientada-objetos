using System;

namespace aula_2_programacao_orientada_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro("Your Name Edição Única", 
                        "Edição única que reúne os três volumes do mangá baseado em Your Name., um dos filmes animados de maior sucesso da história do Japão.", 
                        99.90, "‎8545713606", 
                        "Makoto Shinkai", 
                        "123456789404", 
                        "makoto.shinkai@fakemail.com");
            
            livro.ExibeDados();

            livro.AplicaDescontoDe(0.11);

            livro.ExibeDados();


            double darUmDescontinho = livro.RetornaValorDoDesconto(0.5);
            livro.AplicaDescontoDe(0.5);
            Console.WriteLine($"Aplicando descontinho {darUmDescontinho}");
            livro.ExibeDados();


            Livro outroLivro = new Livro("Your Name Edição Única", 
                        "Edição única que reúne os três volumes do mangá baseado em Your Name., um dos filmes animados de maior sucesso da história do Japão.", 
                        99.90, "‎8545713606", 
                        "Makoto Shinkai", 
                        "123456789404", 
                        "makoto.shinkai@fakemail.com");


            if(livro.RetornaNomeDoLivro() == outroLivro.RetornaNomeDoLivro()) {
                Console.WriteLine("Os livros são iguais!");
            } else {
                Console.WriteLine("Os livros são diferentes!");
            }

        }
    }
}
