
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
                        InserirLivro();
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

        static void InserirLivro()
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
        static void ListarLivros()
        {
            for (int i = 0; i < listLivros.Count; i++)
            {
                Livro livro = listLivros[i];
                Console.Write($"#{i} -");
                Console.WriteLine(livro);
            }
        }
        static void EditarLivro()
        {
            Console.Write("Digite o código do livro que deseja editar: ");
            int indiceLivro = int.Parse(Console.ReadLine());

            if(listLivros.Contains(listLivros[indiceLivro]))
            {
               {
                    Console.Write("Informe o campo que deseja alterar ou digite SAIR: ");
                    string opcaoUsuario = Console.ReadLine().ToUpper();
                        
                    while (opcaoUsuario.ToUpper() != "SAIR")
                    {
                        switch (opcaoUsuario)
                        {
                            case "NOME":
                                Console.Write("Digite o nome: ");
                                listLivros[indiceLivro].Nome = Console.ReadLine().ToUpper();
                                Console.WriteLine("Alteração concluída.");
                                break;
                            case "AUTOR":
                                Console.Write("Digite o Autor: ");
                                listLivros[indiceLivro].Autor = Console.ReadLine().ToUpper();
                                break;
                        }
                        Console.Write("Informe o campo que deseja alterar ou digite SAIR: ");
                        opcaoUsuario = Console.ReadLine().ToUpper();
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
    }
}

