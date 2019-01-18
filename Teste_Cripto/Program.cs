using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;


namespace Teste_Cripto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mantendo o Loop
            bool exit = false;

            //Gerando Hash 
            string passwordExample = "Teste123";
            string hash = Hashing.HashPassword(passwordExample);

            while (exit == false) { 
                //Coletando Credencial
                Console.WriteLine("Entre com sua credencial: ");
                string entrance = Console.ReadLine();
                var autheticated = Hashing.ValidatePassword(entrance, hash); //Comparando hashs

                if (autheticated)
                {
                    Console.WriteLine("\nValidado");          
                }
                else
                {
                    Console.WriteLine("\nNão Validado");
                }
                Console.WriteLine("Hash01 - "+ hash);
                Console.WriteLine("Hash02 - " + Hashing.HashPassword(entrance));
                Console.WriteLine("\nDigite 1 para sair e 2 para reiniciar");
                string response = Console.ReadLine();
                if (response == "1") {
                    exit = true;
                }
                Console.Clear(); // limpar tela
            }

        }
    }
}
