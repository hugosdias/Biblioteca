namespace Biblioteca
{
    public class Menu
    {
        public static string MenuPrincipal()
        {
            Console.WriteLine();
            Console.WriteLine("Livraria!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Cadastrar Livro");
            Console.WriteLine("2 - Listar Livros");
            Console.WriteLine("3 - Editar Livro");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        } 
    }
}