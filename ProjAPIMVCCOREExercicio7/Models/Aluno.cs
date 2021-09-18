using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjAPIMVCCOREExercicio7.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNasc { get; set; }
        public string Endereco { get; set; }
    }
}
