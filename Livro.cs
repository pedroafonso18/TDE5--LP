class Livro {
    public string titulo;
    public string autor;
    public int ano;
    public int paginas;

    public void ExibirInformacoes(){
        Console.WriteLine($"O livro possui o título: {titulo}, o autor: {autor}, foi lançado no ano: {ano}, e tem {paginas} páginas.");
    }

    public void ContarPaginas(){
        if (paginas > 300){
            Console.WriteLine($"O livro possui mais de 300 páginas, possuindo exatamente {paginas} páginas.");
        }
        else{
            Console.WriteLine($"O livro não possui mais de 300 páginas, possuindo exatamente {paginas} páginas");
        }
    }
}