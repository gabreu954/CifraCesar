using CriptografiaCesar.Util;
using System;

namespace CriptografiaCesar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int opcao = -1;

                #region [+] Loop processo

                while (opcao != 0)
                {
              
                    string mensagem = "";
                    int chave = 0;

                    MenuOpcao();

                    opcao = Convert.ToInt32(Console.ReadLine());

                    #region [+] Criptografar
                    if (opcao == 1)
                    {
                        // Criptografa
                        Criptografar criptografar = new Criptografar();
                        Console.Write("Digite sua mensagem: ");
                        mensagem = Console.ReadLine();
                        Console.Write("Digite sua chave: ");
                        chave = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Resultado: " + criptografar.CriptografarTexto(mensagem, chave));

                        continue;

                    }

                    #endregion

                    #region [+] Descriptografar
                    if (opcao == 2)
                    {
                        // Descriptografa
                        Descriptografar descriptografar = new Descriptografar();
                        Console.Write("Digite sua mensagem: ");
                        mensagem = Console.ReadLine();
                        Console.Write("Digite sua chave: ");
                        chave = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Resultado: " + descriptografar.DescriptografarTexto(mensagem, chave));

                        continue;
                    }

                    #endregion

                    if (opcao == 0)
                        Environment.Exit(0);
                }
                #endregion

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(1);
            }

        }

        #region [+] Menu Opções
        public static void MenuOpcao()
        {
            Console.Write("|---------------------------------|\n");
            Console.WriteLine("1 - Criptografar \n");
            Console.WriteLine("2 - Descriptografar \n");
            Console.WriteLine("0 - Sair \n");
            Console.Write("|---------------------------------|\n");

            Console.Write("Escolha uma opção: ");
        }
        #endregion
    }
}
