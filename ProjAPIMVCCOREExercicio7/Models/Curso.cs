using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjAPIMVCCOREExercicio7.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public Aluno Aluno { get; set; }
        public Disciplina Disciplina { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
