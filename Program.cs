namespace teste
{
    internal class Program
    {
        static List<Livro> listLivros = new List<Livro>();
        private static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        CadastrarLivro();
                        break;
                    case "2":
                        ListarLivros();
                        break;
                    case "3":
                        EditarLivro();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
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
            Console.Write("Digite o código do livro que deseja editar: ");
            int indiceLivro = int.Parse(Console.ReadLine());

            if(listLivros.Contains(listLivros[indiceLivro]))
            {
               {                 
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
                            case "X":
                                return;
                        }
                        opcaoUsuario = OpcaoUsuarioEditarLivro();
                    }                  
                }
            }
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Livraria!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Cadastrar Livro");
            Console.WriteLine("2 - Listar Livros");
            Console.WriteLine("3 - Editar Livro");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static string OpcaoUsuarioEditarLivro()
        {
            Console.Write("Seleciona a opção abaixo: ");
            Console.WriteLine();
            Console.WriteLine("1 - Editar NOME do LIVRO");
            Console.WriteLine("2 - Editar NOME do AUTOR");
            Console.WriteLine("3 - Editar GENERO do LIVRO");
            Console.WriteLine("X - Retornar ao menu principal");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}

