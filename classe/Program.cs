using System;

namespace classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inicio");

            Console.WriteLine("Digite 1 se for mulher | Digite 2 se for homem: | Digite 3 para sair");
            int escolhaHomemMulher = Convert.ToInt32(Console.ReadLine());

            while(escolhaHomemMulher < 3) 
            switch (escolhaHomemMulher)
            {
                case 1:
                //PerguntasUsuario(nomeCompleto, dataNascimento);
                //Pessoa mulher = new Mulher(nomeCompleto);
                //mulher.SetarAnoNascimento(dataNascimento);
                //Console.WriteLine($"Seu nome é: {mulher.Nome}. Sua idade é: {mulher.Idade}");
                break;

                case 2:
                //PerguntasUsuario(nomeCompleto, dataNascimento);
                //Pessoa homem = new Homem(nomeCompleto);
                //homem.SetarAnoNascimento(dataNascimento);
                //Console.WriteLine($"Seu nome é: {homem.Nome}. Sua idade é: {homem.Idade}");
                break;

                case 3:
                    break;

                default:
                    break;
            }
            Console.WriteLine("fim");
            Console.ReadLine();
        }
        static void PerguntasUsuario(string nomeCompleto, int dataNascimento)
        {
            Console.WriteLine("Digite seu nome completo: ");
            nomeCompleto = Console.ReadLine();
            Console.WriteLine("Digite seu ano de nascimento: ");
            dataNascimento = Convert.ToInt32(Console.ReadLine());
        }
    }
}