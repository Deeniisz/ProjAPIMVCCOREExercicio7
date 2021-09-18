using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjAPIMVCCOREExercicio7.Models;

namespace ProjAPIMVCCOREExercicio7.Data
{
    public class ProjAPIMVCCOREExercicio7Context : DbContext
    {
        public ProjAPIMVCCOREExercicio7Context (DbContextOptions<ProjAPIMVCCOREExercicio7Context> options)
            : base(options)
        {
        }

        public DbSet<ProjAPIMVCCOREExercicio7.Models.Aluno> Aluno { get; set; }

        public DbSet<ProjAPIMVCCOREExercicio7.Models.Disciplina> Disciplina { get; set; }

        public DbSet<ProjAPIMVCCOREExercicio7.Models.Curso> Curso { get; set; }
    }
}
