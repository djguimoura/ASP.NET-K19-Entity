using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19EntityFramework
{
    public class Teste
    {
        static void Main(string[] args) 
        {
            using (var ctx = new K19Context())
            {
                Aluno a1 = new Aluno
                {
                    Nome = "Guilherme Moura",
                    Endereco = new Endereco
                    {
                        Logradouro = "Rua 1",
                        Numero = 111,
                        CEP = "02998-589"
                    }
                };
                Aluno a2 = new Aluno
                {
                    Nome = "Marcelo Martins ",
                    Endereco = new Endereco
                    {
                        Logradouro = " Rua Zaul ",
                        Numero = 2907,
                        CEP = " 09147-001 "
                    }
                };
                Professor p = new Professor
                {
                    Nome = "Jonas Brothers",
                    Endereco = new Endereco
                    {
                        Logradouro = "Rua 3",
                        Numero = 56897,
                        CEP = "589879-879"
                    }
                };
                Turma t1 = new Turma
                {
                    Vagas = 10,
                    Alunos = new List<Aluno>()
                };

                Turma t2 = new Turma
                {
                    Vagas = 10,
                    Alunos = new List<Aluno>()
                };

                t1.Professor = p;
                t2.Professor = p;
                t1.Alunos.Add(a1);
                t2.Alunos.Add(a2);

                ctx.Turmas.Add(t1);
                ctx.Turmas.Add(t2);
                ctx.SaveChanges();

            }
            System.Console.WriteLine("Tecle enter para continuar...");
            System.Console.ReadKey();
        }
    }
}
