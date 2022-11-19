namespace teste
{
    internal class Program
    {
        
        private static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Livro.CadastrarLivro();
                        break;
                    case "2":
                        Livro.ListarLivros();
                        break;
                    case "3":
                        Livro.EditarLivro();
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

