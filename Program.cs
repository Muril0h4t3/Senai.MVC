using System;
using Senai.MVC.exemplo.ViewsControllers;

namespace Senai.MVC.exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioViewController usuarioViewController = new UsuarioViewController();
            
            int opcao = 0;
            do
            {
             System.Console.WriteLine("-------MENU-------\n[1]- Cadastrar-se\n[2]- Fazer login\n[3]- Listar usuários\n[0]- Sair"); 
             opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                usuarioViewController.CadastroUsuario();
                break;

                case 2:
                 usuarioViewController.Login();
                 break;
                
                case 3:
                usuarioViewController.ListarUsuarios();
                break;

                case 0:
                System.Console.WriteLine("Até mais!");
                break;

                default:
                break;
            }
            } while (opcao != 0);
        }
    }
}
