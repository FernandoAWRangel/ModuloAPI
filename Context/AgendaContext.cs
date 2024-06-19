using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
    public class AgendaContext :  DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) //Recebe uma configuração da BD
        {

        }

        //Representa uma tabela, vai acessar os registros da tabela Contato chamando a propriedade "Contatos"
        // Se a classe não está no DbSet não será identificada como tabela, ou seja, a entidade precisa ser um DbSet no AgendaContext
        public DbSet<Contato> Contatos{ get; set; } 
    }
}