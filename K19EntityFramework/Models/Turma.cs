using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace K19EntityFramework
{
    [Table("tbl_turmas")]
    public class Turma
    {
        public int TurmaId { get; set; }
        public int Vagas { get; set; }
        public Professor Professor { get; set; }
        public ICollection<Aluno> Alunos { get; set; }
    }
}
