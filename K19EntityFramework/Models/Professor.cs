using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace K19EntityFramework
{
    [Table("tbl_professor")]
    public class Professor
    {
        public int ProfessorID { get; set; }
        [Required]
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
    }
}
