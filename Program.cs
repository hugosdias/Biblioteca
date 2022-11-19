namespace Biblioteca
{
    internal class Program
    {       
        private static void Main(string[] args)
        {
            string opcaoUsuario = Menu.MenuPrincipal();

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
                opcaoUsuario = Menu.MenuPrincipal();
            }
        }             
    }
}

