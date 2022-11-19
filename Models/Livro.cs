namespace Biblioteca
{
    public class Livro
    {
        static List<Livro> listLivros = new List<Livro>();
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string Ano { get; set; }
        public string Editora { get; set; }
        public Livro(string nome, string autor, string genero, string ano, string editora)
        {
            this.Nome = nome;
            this.Autor = autor;
            this.Genero = genero;
            this.Ano = ano;
            this.Editora = editora;
        }

        public override string ToString()
        {
            string retorno = " ";
            retorno += "Nome do Livro: " + this.Nome + " | ";
            retorno += "Autor: " + this.Autor + " | ";
            retorno += "Genero: " + this.Genero + " | ";
            retorno += "Ano: " + this.Ano + " | ";
            retorno += "Editora: " + this.Editora;
            return retorno;
        }

        public static void CadastrarLivro()
        {
            Console.Write("Nome do Livro: ");
            string nomeLivro = Console.ReadLine().ToUpper();

            Console.Write("Autor: ");
            string autorLivro = Console.ReadLine().ToUpper();

            Console.Write("Genero: ");
            string generoLivro = Console.ReadLine().ToUpper();

            Console.Write("Ano: ");
            string anoLivro = Console.ReadLine().ToUpper();

            Console.Write("Editora: ");
            string editoraLivro = Console.ReadLine().ToUpper();

            Livro novoLivro = new Livro(nome: nomeLivro, autor: autorLivro, genero: generoLivro, ano: anoLivro, editora: editoraLivro);

            listLivros.Add(novoLivro);

            Console.Write("Livro Cadastrado com Sucesso.");
            Console.WriteLine();
        }
        public static void ListarLivros()
        {
            for (int i = 0; i < listLivros.Count; i++)
            {
                Livro livro = listLivros[i];
                Console.Write($"#{i} -");
                Console.WriteLine(livro);
            }
        }
        public static void EditarLivro()
        {
            Console.WriteLine("EDITAR LIVRO!");
            Console.Write("Digite o código do LIVRO: ");
            int indiceLivro = int.Parse(Console.ReadLine());

            try
            {
                if (listLivros.Contains(listLivros[indiceLivro]))
                {
                    Console.WriteLine($"Livro Selecionado: ");
                    Console.WriteLine($"{listLivros[indiceLivro].ToString()}");
                    Console.WriteLine();

                    string opcaoUsuario = OpcaoUsuarioEditarLivro();

                    while (opcaoUsuario.ToUpper() != "x")
                    {
                        switch (opcaoUsuario)
                        {
                            case "1":
                                Console.Write("Digite o NOME do Livro: ");
                                listLivros[indiceLivro].Nome = Console.ReadLine().ToUpper();
                                Console.WriteLine("Alteração concluída.");
                                Console.WriteLine();
                                break;
                            case "2":
                                Console.Write("Digite o AUTOR do Livro: ");
                                listLivros[indiceLivro].Autor = Console.ReadLine().ToUpper();
                                Console.WriteLine("Alteração concluída.");
                                Console.WriteLine();
                                break;
                            case "3":
                                Console.Write("Digite o GENERO do Livro: ");
                                listLivros[indiceLivro].Genero = Console.ReadLine().ToUpper();
                                Console.WriteLine("Alteração concluída.");
                                Console.WriteLine();
                                break;
                            case "4":
                                Console.Write("Digite o ANO do Livro: ");
                                listLivros[indiceLivro].Ano = Console.ReadLine().ToUpper();
                                Console.WriteLine("Alteração concluída.");
                                Console.WriteLine();
                                break;
                            case "5":
                                Console.WriteLine("Digite a EDITORA do Livro: ");
                                listLivros[indiceLivro].Editora = Console.ReadLine().ToUpper();
                                Console.WriteLine("Alteração concluída.");
                                Console.WriteLine();
                                break;
                            case "X":
                                return;
                        }
                        opcaoUsuario = OpcaoUsuarioEditarLivro();
                    }
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Livro não encontrado.");
                return;
            }
        }

        private static string OpcaoUsuarioEditarLivro()
        {
            Console.Write("Seleciona a opção abaixo: ");
            Console.WriteLine();
            Console.WriteLine("1 - Editar NOME do LIVRO");
            Console.WriteLine("2 - Editar NOME do AUTOR");
            Console.WriteLine("3 - Editar GENERO do LIVRO");
            Console.WriteLine("4 - Editar ANO do LIVRO");
            Console.WriteLine("5 - Editar EDITORA do LIVRO");
            Console.WriteLine("X - Retornar ao menu principal");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}