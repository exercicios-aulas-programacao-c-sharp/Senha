using System;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            const string senha = "1234abcd";
            string senhaInformada;

            Console.Write("Olá, usuário. Por favor, digite sua senha: ");
            senhaInformada = Console.ReadLine();

            if (senha.Equals(senhaInformada)){
                Console.WriteLine("Acesso permitido");
            }else{
                Console.WriteLine("Acesso negado");
            }
        }
    }
}
