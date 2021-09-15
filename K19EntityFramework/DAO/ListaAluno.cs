using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19EntityFramework.DAO
{
    public class ListaAluno
    {
        static void Main(string[] args)
        {
            using(var ctx = new K19Context())
            {
                var consulta = from aluno in ctx.Alunos select aluno;

                foreach (Aluno aluno in consulta)
                {
                    Console.WriteLine("Nome: " + aluno.Nome);
                    Console.WriteLine("Logradouro: " + aluno.Endereco.Logradouro);
                    Console.WriteLine("Numero: " + aluno.Endereco.Numero);
                    Console.WriteLine("Cep: " + aluno.Endereco.CEP);
                    Console.WriteLine("-------------------------------------------");
                }
                Console.WriteLine("Tecle enter para continuar...");
                Console.ReadKey();
            }
        }
    }
}
