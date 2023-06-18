using Biblioteca;

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
            throw ArgumentOutOfRangeException();
            
    }
    opcaoUsuario = Menu.MenuPrincipal();
}

Exception ArgumentOutOfRangeException()
{
    throw new NotImplementedException();
}
//teste

