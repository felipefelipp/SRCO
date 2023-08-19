using Microsoft.EntityFrameworkCore;
using Models.Classificacao;
using SCRO.Models.Paciente;
using SCRO.Models.Classificacao;
using SCRO.Models.Paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.SCRO.Models.Data
{
    public class SCROContext : DbContext
    {
        
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Responsavel> Responsaveis { get; set; }
        //public DbSet<Perguntas> Pergunta { get; set; }
        //public DbSet<Respostas> Resposta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SCRO;Trusted_Connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PacienteConfiguration());
            modelBuilder.ApplyConfiguration(new ResponsavelConfiguration());
        }

    }
}
