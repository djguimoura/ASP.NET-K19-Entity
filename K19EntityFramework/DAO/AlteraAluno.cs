using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19EntityFramework.DAO
{
    public class AlteraAluno
    {
        static void Main(string[] args)
        {
            using (var ctx = new K19Context())
            {
                Aluno aluno = ctx.Alunos.Find(2);
                aluno.Nome = "Jé Motta";

                ctx.SaveChanges();

                Console.WriteLine("Dados alterados com sucesso! \n" + "Nome novo: " + aluno.Nome);
                Console.ReadKey();
            }
        }
    }
}
