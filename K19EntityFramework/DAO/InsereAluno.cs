using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19EntityFramework.DAO
{
    public class InsereAluno
    {
        static void Main(string[] args)
        {
            using(var ctx = new K19Context())
            {
                Console.WriteLine("Digite o nome do aluno: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o logradouro do endereço do aluno: ");
                string logradouro = Console.ReadLine();

                Console.WriteLine("Digite o número do endereço do aluno: ");
                int numero = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Digite o CEP do endereço do aluno: ");
                string cep = Console.ReadLine();

                Console.WriteLine("Tecle enter para finalizar...");
                Console.ReadKey();

                Aluno aluno1 = new Aluno()
                {
                    Nome = nome,
                    Endereco = new Endereco
                    {
                        Logradouro = logradouro,
                        Numero = numero,
                        CEP = cep
                    }
                };

                ctx.Alunos.Add(aluno1);
                ctx.SaveChanges();
            }
        }
    }
}
